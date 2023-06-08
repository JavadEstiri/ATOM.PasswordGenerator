namespace ATOM.PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_GeneratedPassword = new Label();
            chb_IncludeAlphabets = new CheckBox();
            chb_IncludeSymbol = new CheckBox();
            chb_IncludeNumbers = new CheckBox();
            chb_IsCaseSensitive = new CheckBox();
            btn_Generate = new Button();
            btn_Copy = new Button();
            lbl_ = new Label();
            trb_Complexity = new TrackBar();
            label1 = new Label();
            nud_Length = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)trb_Complexity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Length).BeginInit();
            SuspendLayout();
            // 
            // lbl_GeneratedPassword
            // 
            lbl_GeneratedPassword.BackColor = SystemColors.ControlLightLight;
            lbl_GeneratedPassword.Enabled = false;
            lbl_GeneratedPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GeneratedPassword.Location = new Point(103, 163);
            lbl_GeneratedPassword.Name = "lbl_GeneratedPassword";
            lbl_GeneratedPassword.Size = new Size(314, 50);
            lbl_GeneratedPassword.TabIndex = 0;
            lbl_GeneratedPassword.Text = "Password Shown Here";
            lbl_GeneratedPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chb_IncludeAlphabets
            // 
            chb_IncludeAlphabets.AutoSize = true;
            chb_IncludeAlphabets.Location = new Point(12, 25);
            chb_IncludeAlphabets.Name = "chb_IncludeAlphabets";
            chb_IncludeAlphabets.Size = new Size(150, 24);
            chb_IncludeAlphabets.TabIndex = 1;
            chb_IncludeAlphabets.Text = "Include Alphabets";
            chb_IncludeAlphabets.TextAlign = ContentAlignment.MiddleCenter;
            chb_IncludeAlphabets.UseVisualStyleBackColor = true;
            // 
            // chb_IncludeSymbol
            // 
            chb_IncludeSymbol.AutoSize = true;
            chb_IncludeSymbol.Location = new Point(12, 85);
            chb_IncludeSymbol.Name = "chb_IncludeSymbol";
            chb_IncludeSymbol.Size = new Size(133, 24);
            chb_IncludeSymbol.TabIndex = 2;
            chb_IncludeSymbol.Text = "Include Symbol";
            chb_IncludeSymbol.TextAlign = ContentAlignment.MiddleCenter;
            chb_IncludeSymbol.UseVisualStyleBackColor = true;
            // 
            // chb_IncludeNumbers
            // 
            chb_IncludeNumbers.AutoSize = true;
            chb_IncludeNumbers.Location = new Point(12, 115);
            chb_IncludeNumbers.Name = "chb_IncludeNumbers";
            chb_IncludeNumbers.Size = new Size(143, 24);
            chb_IncludeNumbers.TabIndex = 3;
            chb_IncludeNumbers.Text = "Include Numbers";
            chb_IncludeNumbers.TextAlign = ContentAlignment.MiddleCenter;
            chb_IncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // chb_IsCaseSensitive
            // 
            chb_IsCaseSensitive.AutoSize = true;
            chb_IsCaseSensitive.Location = new Point(12, 55);
            chb_IsCaseSensitive.Name = "chb_IsCaseSensitive";
            chb_IsCaseSensitive.Size = new Size(138, 24);
            chb_IsCaseSensitive.TabIndex = 4;
            chb_IsCaseSensitive.Text = "Is Case Sensitive";
            chb_IsCaseSensitive.TextAlign = ContentAlignment.MiddleCenter;
            chb_IsCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // btn_Generate
            // 
            btn_Generate.Location = new Point(15, 163);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(82, 50);
            btn_Generate.TabIndex = 5;
            btn_Generate.Text = "Generate";
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += btn_Generate_Click;
            // 
            // btn_Copy
            // 
            btn_Copy.Location = new Point(423, 163);
            btn_Copy.Name = "btn_Copy";
            btn_Copy.Size = new Size(60, 50);
            btn_Copy.TabIndex = 6;
            btn_Copy.Text = "Copy";
            btn_Copy.UseVisualStyleBackColor = true;
            btn_Copy.Click += btn_Copy_Click;
            // 
            // lbl_
            // 
            lbl_.Location = new Point(206, 9);
            lbl_.Name = "lbl_";
            lbl_.Size = new Size(130, 27);
            lbl_.TabIndex = 8;
            lbl_.Text = "Complexity Level :";
            lbl_.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trb_Complexity
            // 
            trb_Complexity.LargeChange = 1;
            trb_Complexity.Location = new Point(206, 39);
            trb_Complexity.Maximum = 3;
            trb_Complexity.Minimum = 1;
            trb_Complexity.Name = "trb_Complexity";
            trb_Complexity.Size = new Size(285, 56);
            trb_Complexity.TabIndex = 3;
            trb_Complexity.Value = 1;
            // 
            // label1
            // 
            label1.Location = new Point(206, 102);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 11;
            label1.Text = "Length :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nud_Length
            // 
            nud_Length.Location = new Point(277, 102);
            nud_Length.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nud_Length.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nud_Length.Name = "nud_Length";
            nud_Length.Size = new Size(95, 27);
            nud_Length.TabIndex = 13;
            nud_Length.TextAlign = HorizontalAlignment.Center;
            nud_Length.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-5, 231);
            label2.Name = "label2";
            label2.Size = new Size(511, 37);
            label2.TabIndex = 14;
            label2.Text = "Atom - Web Design Team";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(501, 263);
            Controls.Add(label2);
            Controls.Add(nud_Length);
            Controls.Add(label1);
            Controls.Add(trb_Complexity);
            Controls.Add(lbl_);
            Controls.Add(btn_Copy);
            Controls.Add(btn_Generate);
            Controls.Add(chb_IsCaseSensitive);
            Controls.Add(chb_IncludeNumbers);
            Controls.Add(chb_IncludeSymbol);
            Controls.Add(chb_IncludeAlphabets);
            Controls.Add(lbl_GeneratedPassword);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Atom - Password Generator";
            ((System.ComponentModel.ISupportInitialize)trb_Complexity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Length).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_GeneratedPassword;
        private CheckBox chb_IncludeAlphabets;
        private CheckBox chb_IncludeSymbol;
        private CheckBox chb_IncludeNumbers;
        private CheckBox chb_IsCaseSensitive;
        private Button btn_Generate;
        private Button btn_Copy;
        private Label lbl_;
        private TrackBar trb_Complexity;
        private Label label1;
        private NumericUpDown nud_Length;
        private Label label2;
    }
}