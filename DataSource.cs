using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.PasswordGenerator
{
    public class DataSource
    {
        public DataSource(bool _alphabet, bool _caseSensitive, bool _symbol, bool _number)
        {
            this.Options = new List<char>();

            if (_symbol)
            {
                Include_Symbol = true;
                Options.AddRange(Symbol);
            }

            if (_number)
            {
                Include_Number = true;
                Options.AddRange(Number);
            }

            if (_alphabet)
            {
                Include_LC = true;
                Options.AddRange(LC_Alphabet);
            }

            if (_caseSensitive)
            {
                Include_UC = true;
                Options.AddRange(UC_Alphabet);
            }
        }

        private bool Include_LC { get; }
        private char[] LC_Alphabet => new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        private bool Include_UC { get; }
        private char[] UC_Alphabet => new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        private bool Include_Symbol { get; }
        private char[] Symbol => new char[] { '!', '@', '#', '$', '%', '&', '^', '*', '(', ')', '{', '}', '[', ']', ';', ':', '.', '?', ',', '\'', '"', '\\', '/', ' ' };

        private bool Include_Number { get; }
        private char[] Number => new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };

        private List<char> Options { get; }

        public string Generate(int length = 10, int complexity = 1)
        {
            if (!Options.Any())
                return string.Empty;

            //List<string> combinations = GetCombinationsWithRepetition(Options, length);

            return GetRandomCombination(Options, length, complexity);
        }

        private string GetRandomCombination(List<char> chars, int length, int complexity)
        {
            Random random = new Random();
            string result = string.Empty;

            if (complexity == 1 || complexity == 2)
                for (int i = 0; i < length; i++)
                    result += chars[random.Next(chars.Count() - 1)].ToString();

            if (complexity == 2)
            {
                result = RemoveDuplicates(result);
                while (result.Length < length)
                {
                    if (result.Length != length)
                        for (int i = result.Length - 1; i < length; i++)
                            result += chars[random.Next(chars.Count() - 1)].ToString();

                    result = RemoveDuplicates(result);
                }
            }
            else if (complexity == 3)
            {
                while (result.Length < length)
                {
                    if (Include_LC)
                        result += LC_Alphabet[random.Next(LC_Alphabet.Count() - 1)].ToString();

                    if (Include_UC)
                        result += UC_Alphabet[random.Next(UC_Alphabet.Count() - 1)].ToString();

                    if (Include_Number)
                        result += Number[random.Next(Number.Count() - 1)].ToString();

                    if (Include_Symbol)
                        result += Symbol[random.Next(Symbol.Count() - 1)].ToString();

                    result = RemoveDuplicates(result);
                }
            }


            return result;

        }

        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        static List<string> GetCombinationsWithRepetition(List<char> chars, int length)
        {
            List<string> combinations = new List<string>();
            if (combinations.Count == 0)
                GenerateCombinations(chars, length, "", combinations);
            return combinations;
        }

        static void GenerateCombinations(List<char> chars, int length, string prefix, List<string> combinations)
        {
            if (prefix.Length == length)
            {
                combinations.Add(prefix);
            }
            else
            {
                foreach (char c in chars)
                {
                    GenerateCombinations(chars, length, prefix + c, combinations);
                }
            }
        }

    }
}
