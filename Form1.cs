namespace ATOM.PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            var generator = new DataSource(_alphabet: chb_IncludeAlphabets.Checked, _caseSensitive: chb_IsCaseSensitive.Checked, _symbol: chb_IncludeSymbol.Checked, _number: chb_IncludeNumbers.Checked);

            var result = generator.Generate(length: Convert.ToInt32(nud_Length.Value), complexity: Convert.ToInt32(trb_Complexity.Value));

            lbl_GeneratedPassword.Text = result;
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_GeneratedPassword.Text);
        }
    }
}