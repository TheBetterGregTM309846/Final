namespace Final
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            FNameBox = new MaterialSkin.Controls.MaterialTextBox2();
            lNameBox = new MaterialSkin.Controls.MaterialTextBox2();
            phoneBox = new MaterialSkin.Controls.MaterialTextBox2();
            IPBox = new MaterialSkin.Controls.MaterialTextBox2();
            descBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            deleteBtn = new MaterialSkin.Controls.MaterialFloatingActionButton();
            addBtn = new MaterialSkin.Controls.MaterialFloatingActionButton();
            searchBox = new MaterialSkin.Controls.MaterialTextBox2();
            updateBtn = new MaterialSkin.Controls.MaterialButton();
            printBtn = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // FNameBox
            // 
            FNameBox.AnimateReadOnly = false;
            FNameBox.BackgroundImageLayout = ImageLayout.None;
            FNameBox.CharacterCasing = CharacterCasing.Normal;
            FNameBox.Depth = 0;
            FNameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            FNameBox.HideSelection = true;
            FNameBox.Hint = "First name";
            FNameBox.LeadingIcon = null;
            FNameBox.Location = new Point(13, 33);
            FNameBox.MaxLength = 32767;
            FNameBox.MouseState = MaterialSkin.MouseState.OUT;
            FNameBox.Name = "FNameBox";
            FNameBox.PasswordChar = '\0';
            FNameBox.PrefixSuffixText = null;
            FNameBox.ReadOnly = false;
            FNameBox.RightToLeft = RightToLeft.No;
            FNameBox.SelectedText = "";
            FNameBox.SelectionLength = 0;
            FNameBox.SelectionStart = 0;
            FNameBox.ShortcutsEnabled = true;
            FNameBox.Size = new Size(200, 48);
            FNameBox.TabIndex = 1;
            FNameBox.TabStop = false;
            FNameBox.TextAlign = HorizontalAlignment.Left;
            FNameBox.TrailingIcon = null;
            FNameBox.UseAccent = false;
            FNameBox.UseSystemPasswordChar = false;
            FNameBox.Click += fNameBox_Click;
            // 
            // lNameBox
            // 
            lNameBox.AnimateReadOnly = false;
            lNameBox.BackgroundImageLayout = ImageLayout.None;
            lNameBox.CharacterCasing = CharacterCasing.Normal;
            lNameBox.Depth = 0;
            lNameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lNameBox.HideSelection = true;
            lNameBox.Hint = "Last Name";
            lNameBox.LeadingIcon = null;
            lNameBox.Location = new Point(219, 33);
            lNameBox.MaxLength = 32767;
            lNameBox.MouseState = MaterialSkin.MouseState.OUT;
            lNameBox.Name = "lNameBox";
            lNameBox.PasswordChar = '\0';
            lNameBox.PrefixSuffixText = null;
            lNameBox.ReadOnly = false;
            lNameBox.RightToLeft = RightToLeft.No;
            lNameBox.SelectedText = "";
            lNameBox.SelectionLength = 0;
            lNameBox.SelectionStart = 0;
            lNameBox.ShortcutsEnabled = true;
            lNameBox.Size = new Size(192, 48);
            lNameBox.TabIndex = 2;
            lNameBox.TabStop = false;
            lNameBox.TextAlign = HorizontalAlignment.Left;
            lNameBox.TrailingIcon = null;
            lNameBox.UseAccent = false;
            lNameBox.UseSystemPasswordChar = false;
            // 
            // phoneBox
            // 
            phoneBox.AnimateReadOnly = false;
            phoneBox.BackgroundImageLayout = ImageLayout.None;
            phoneBox.CharacterCasing = CharacterCasing.Normal;
            phoneBox.Depth = 0;
            phoneBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneBox.HideSelection = true;
            phoneBox.Hint = "Phone";
            phoneBox.LeadingIcon = null;
            phoneBox.Location = new Point(13, 87);
            phoneBox.MaxLength = 32767;
            phoneBox.MouseState = MaterialSkin.MouseState.OUT;
            phoneBox.Name = "phoneBox";
            phoneBox.PasswordChar = '\0';
            phoneBox.PrefixSuffixText = null;
            phoneBox.ReadOnly = false;
            phoneBox.RightToLeft = RightToLeft.No;
            phoneBox.SelectedText = "";
            phoneBox.SelectionLength = 0;
            phoneBox.SelectionStart = 0;
            phoneBox.ShortcutsEnabled = true;
            phoneBox.Size = new Size(398, 48);
            phoneBox.TabIndex = 3;
            phoneBox.TabStop = false;
            phoneBox.TextAlign = HorizontalAlignment.Left;
            phoneBox.TrailingIcon = null;
            phoneBox.UseAccent = false;
            phoneBox.UseSystemPasswordChar = false;
            // 
            // IPBox
            // 
            IPBox.AnimateReadOnly = false;
            IPBox.BackgroundImageLayout = ImageLayout.None;
            IPBox.CharacterCasing = CharacterCasing.Normal;
            IPBox.Depth = 0;
            IPBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IPBox.HideSelection = true;
            IPBox.Hint = "Address";
            IPBox.LeadingIcon = null;
            IPBox.Location = new Point(13, 141);
            IPBox.MaxLength = 32767;
            IPBox.MouseState = MaterialSkin.MouseState.OUT;
            IPBox.Name = "IPBox";
            IPBox.PasswordChar = '\0';
            IPBox.PrefixSuffixText = null;
            IPBox.ReadOnly = false;
            IPBox.RightToLeft = RightToLeft.No;
            IPBox.SelectedText = "";
            IPBox.SelectionLength = 0;
            IPBox.SelectionStart = 0;
            IPBox.ShortcutsEnabled = true;
            IPBox.Size = new Size(398, 48);
            IPBox.TabIndex = 4;
            IPBox.TabStop = false;
            IPBox.TextAlign = HorizontalAlignment.Left;
            IPBox.TrailingIcon = null;
            IPBox.UseAccent = false;
            IPBox.UseSystemPasswordChar = false;
            // 
            // descBox
            // 
            descBox.AnimateReadOnly = false;
            descBox.BackgroundImageLayout = ImageLayout.None;
            descBox.CharacterCasing = CharacterCasing.Normal;
            descBox.Depth = 0;
            descBox.HideSelection = true;
            descBox.Hint = "Prescription and comments";
            descBox.Location = new Point(13, 195);
            descBox.MaxLength = 32767;
            descBox.MouseState = MaterialSkin.MouseState.OUT;
            descBox.Name = "descBox";
            descBox.PasswordChar = '\0';
            descBox.ReadOnly = false;
            descBox.ScrollBars = ScrollBars.None;
            descBox.SelectedText = "";
            descBox.SelectionLength = 0;
            descBox.SelectionStart = 0;
            descBox.ShortcutsEnabled = true;
            descBox.Size = new Size(398, 129);
            descBox.TabIndex = 5;
            descBox.TabStop = false;
            descBox.TextAlign = HorizontalAlignment.Left;
            descBox.UseAccent = false;
            descBox.UseSystemPasswordChar = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Depth = 0;
            deleteBtn.Icon = (Image)resources.GetObject("deleteBtn.Icon");
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(693, 389);
            deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(56, 56);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "materialFloatingActionButton1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Depth = 0;
            addBtn.Icon = (Image)resources.GetObject("addBtn.Icon");
            addBtn.Location = new Point(427, 29);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(56, 56);
            addBtn.TabIndex = 7;
            addBtn.Text = "materialFloatingActionButton2";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // searchBox
            // 
            searchBox.AnimateReadOnly = false;
            searchBox.BackgroundImageLayout = ImageLayout.None;
            searchBox.CharacterCasing = CharacterCasing.Normal;
            searchBox.Depth = 0;
            searchBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchBox.HideSelection = true;
            searchBox.Hint = "Search by last name";
            searchBox.LeadingIcon = null;
            searchBox.Location = new Point(5, 335);
            searchBox.MaxLength = 32767;
            searchBox.MouseState = MaterialSkin.MouseState.OUT;
            searchBox.Name = "searchBox";
            searchBox.PasswordChar = '\0';
            searchBox.PrefixSuffixText = null;
            searchBox.ReadOnly = false;
            searchBox.RightToLeft = RightToLeft.No;
            searchBox.SelectedText = "";
            searchBox.SelectionLength = 0;
            searchBox.SelectionStart = 0;
            searchBox.ShortcutsEnabled = true;
            searchBox.Size = new Size(670, 48);
            searchBox.TabIndex = 8;
            searchBox.TabStop = false;
            searchBox.TextAlign = HorizontalAlignment.Left;
            searchBox.TrailingIcon = Properties.Resources._1200px_Magnifying_glass_icon_svg;
            searchBox.UseAccent = false;
            searchBox.UseSystemPasswordChar = false;
            searchBox.LeadingIconClick += searchBox_LeadingIconClick;
            searchBox.TrailingIconClick += searchBox_TrailingIconClick;
            // 
            // updateBtn
            // 
            updateBtn.AutoSize = false;
            updateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateBtn.Depth = 0;
            updateBtn.HighEmphasis = true;
            updateBtn.Icon = null;
            updateBtn.Location = new Point(681, 454);
            updateBtn.Margin = new Padding(4, 6, 4, 6);
            updateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateBtn.Name = "updateBtn";
            updateBtn.NoAccentTextColor = Color.Empty;
            updateBtn.Size = new Size(75, 36);
            updateBtn.TabIndex = 9;
            updateBtn.Text = "Update";
            updateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateBtn.UseAccentColor = false;
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // printBtn
            // 
            printBtn.AutoSize = false;
            printBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            printBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            printBtn.Depth = 0;
            printBtn.HighEmphasis = true;
            printBtn.Icon = null;
            printBtn.Location = new Point(682, 509);
            printBtn.Margin = new Padding(4, 6, 4, 6);
            printBtn.MouseState = MaterialSkin.MouseState.HOVER;
            printBtn.Name = "printBtn";
            printBtn.NoAccentTextColor = Color.Empty;
            printBtn.Size = new Size(75, 36);
            printBtn.TabIndex = 10;
            printBtn.Text = "Print";
            printBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            printBtn.UseAccentColor = false;
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += prntBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(5, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 317);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding a patient";
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(5, 389);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.Height = 25;
            gridView.Size = new Size(670, 250);
            gridView.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 649);
            Controls.Add(gridView);
            Controls.Add(printBtn);
            Controls.Add(updateBtn);
            Controls.Add(searchBox);
            Controls.Add(addBtn);
            Controls.Add(deleteBtn);
            Controls.Add(descBox);
            Controls.Add(IPBox);
            Controls.Add(phoneBox);
            Controls.Add(lNameBox);
            Controls.Add(FNameBox);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 FNameBox;
        private MaterialSkin.Controls.MaterialTextBox2 lNameBox;
        private MaterialSkin.Controls.MaterialTextBox2 phoneBox;
        private MaterialSkin.Controls.MaterialTextBox2 IPBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 descBox;
        private MaterialSkin.Controls.MaterialFloatingActionButton deleteBtn;
        private MaterialSkin.Controls.MaterialFloatingActionButton addBtn;
        private MaterialSkin.Controls.MaterialTextBox2 searchBox;
        private MaterialSkin.Controls.MaterialButton updateBtn;
        private MaterialSkin.Controls.MaterialButton printBtn;
        private GroupBox groupBox1;
        private DataGridView gridView;
    }
}