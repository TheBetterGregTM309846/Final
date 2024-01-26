namespace Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nameCBox = new MaterialSkin.Controls.MaterialComboBox();
            antiLoggusBtn = new MaterialSkin.Controls.MaterialButton();
            forgor = new MaterialSkin.Controls.MaterialLabel();
            passBox = new MaterialSkin.Controls.MaterialTextBox2();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // nameCBox
            // 
            nameCBox.AutoResize = false;
            nameCBox.BackColor = Color.FromArgb(255, 255, 255);
            nameCBox.Depth = 0;
            nameCBox.DrawMode = DrawMode.OwnerDrawVariable;
            nameCBox.DropDownHeight = 174;
            nameCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            nameCBox.DropDownWidth = 121;
            nameCBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            nameCBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            nameCBox.FormattingEnabled = true;
            nameCBox.Hint = "Username";
            nameCBox.IntegralHeight = false;
            nameCBox.ItemHeight = 43;
            nameCBox.Items.AddRange(new object[] { "Gregory Hynes", "Gregory Buckley", "Mann Talati" });
            nameCBox.Location = new Point(51, 16);
            nameCBox.Margin = new Padding(3, 4, 3, 4);
            nameCBox.MaxDropDownItems = 4;
            nameCBox.MouseState = MaterialSkin.MouseState.OUT;
            nameCBox.Name = "nameCBox";
            nameCBox.Size = new Size(289, 49);
            nameCBox.StartIndex = 0;
            nameCBox.TabIndex = 1;
            nameCBox.UseAccent = false;
            // 
            // antiLoggusBtn
            // 
            antiLoggusBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            antiLoggusBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            antiLoggusBtn.Depth = 0;
            antiLoggusBtn.HighEmphasis = true;
            antiLoggusBtn.Icon = null;
            antiLoggusBtn.Location = new Point(55, 196);
            antiLoggusBtn.Margin = new Padding(5, 8, 5, 8);
            antiLoggusBtn.MouseState = MaterialSkin.MouseState.HOVER;
            antiLoggusBtn.Name = "antiLoggusBtn";
            antiLoggusBtn.NoAccentTextColor = Color.Empty;
            antiLoggusBtn.Size = new Size(64, 36);
            antiLoggusBtn.TabIndex = 2;
            antiLoggusBtn.Text = "Login";
            antiLoggusBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            antiLoggusBtn.UseAccentColor = false;
            antiLoggusBtn.UseVisualStyleBackColor = true;
            antiLoggusBtn.Click += materialButton1_Click;
            // 
            // forgor
            // 
            forgor.AutoSize = true;
            forgor.Depth = 0;
            forgor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            forgor.Location = new Point(206, 196);
            forgor.MouseState = MaterialSkin.MouseState.HOVER;
            forgor.Name = "forgor";
            forgor.Size = new Size(115, 19);
            forgor.TabIndex = 4;
            forgor.Text = "Caps Lock Is On";
            forgor.Visible = false;
            // 
            // passBox
            // 
            passBox.AnimateReadOnly = false;
            passBox.BackgroundImageLayout = ImageLayout.None;
            passBox.CharacterCasing = CharacterCasing.Normal;
            passBox.Depth = 0;
            passBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passBox.HideSelection = true;
            passBox.Hint = "Password";
            passBox.LeadingIcon = null;
            passBox.Location = new Point(51, 107);
            passBox.Margin = new Padding(3, 4, 3, 4);
            passBox.MaxLength = 32767;
            passBox.MouseState = MaterialSkin.MouseState.OUT;
            passBox.Name = "passBox";
            passBox.PasswordChar = '\0';
            passBox.PrefixSuffixText = null;
            passBox.ReadOnly = false;
            passBox.RightToLeft = RightToLeft.No;
            passBox.SelectedText = "";
            passBox.SelectionLength = 0;
            passBox.SelectionStart = 0;
            passBox.ShortcutsEnabled = true;
            passBox.Size = new Size(286, 48);
            passBox.TabIndex = 3;
            passBox.TabStop = false;
            passBox.TextAlign = HorizontalAlignment.Left;
            passBox.TrailingIcon = Properties.Resources.open;
            passBox.UseAccent = false;
            passBox.UseSystemPasswordChar = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 260);
            Controls.Add(forgor);
            Controls.Add(passBox);
            Controls.Add(antiLoggusBtn);
            Controls.Add(nameCBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox nameCBox;
        private MaterialSkin.Controls.MaterialButton antiLoggusBtn;
        private MaterialSkin.Controls.MaterialLabel forgor;
        private MaterialSkin.Controls.MaterialTextBox2 passBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}