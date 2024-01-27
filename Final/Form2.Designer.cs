﻿namespace Final
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
            fNameBox = new MaterialSkin.Controls.MaterialTextBox2();
            lNameBox = new MaterialSkin.Controls.MaterialTextBox2();
            phoneBox = new MaterialSkin.Controls.MaterialTextBox2();
            IPBox = new MaterialSkin.Controls.MaterialTextBox2();
            descBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            deleteBtn = new MaterialSkin.Controls.MaterialFloatingActionButton();
            addBtn = new MaterialSkin.Controls.MaterialFloatingActionButton();
            searchBox = new MaterialSkin.Controls.MaterialTextBox2();
            updateBtn = new MaterialSkin.Controls.MaterialButton();
            prntBtn = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // fNameBox
            // 
            fNameBox.AnimateReadOnly = false;
            fNameBox.BackgroundImageLayout = ImageLayout.None;
            fNameBox.CharacterCasing = CharacterCasing.Normal;
            fNameBox.Depth = 0;
            fNameBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fNameBox.HideSelection = true;
            fNameBox.Hint = "First name";
            fNameBox.LeadingIcon = null;
            fNameBox.Location = new Point(15, 44);
            fNameBox.Margin = new Padding(3, 4, 3, 4);
            fNameBox.MaxLength = 32767;
            fNameBox.MouseState = MaterialSkin.MouseState.OUT;
            fNameBox.Name = "fNameBox";
            fNameBox.PasswordChar = '\0';
            fNameBox.PrefixSuffixText = null;
            fNameBox.ReadOnly = false;
            fNameBox.RightToLeft = RightToLeft.No;
            fNameBox.SelectedText = "";
            fNameBox.SelectionLength = 0;
            fNameBox.SelectionStart = 0;
            fNameBox.ShortcutsEnabled = true;
            fNameBox.Size = new Size(229, 48);
            fNameBox.TabIndex = 1;
            fNameBox.TabStop = false;
            fNameBox.TextAlign = HorizontalAlignment.Left;
            fNameBox.TrailingIcon = null;
            fNameBox.UseAccent = false;
            fNameBox.UseSystemPasswordChar = false;
            fNameBox.Click += fNameBox_Click;
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
            lNameBox.Location = new Point(250, 44);
            lNameBox.Margin = new Padding(3, 4, 3, 4);
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
            lNameBox.Size = new Size(219, 48);
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
            phoneBox.Location = new Point(15, 116);
            phoneBox.Margin = new Padding(3, 4, 3, 4);
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
            phoneBox.Size = new Size(455, 48);
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
            IPBox.Location = new Point(15, 188);
            IPBox.Margin = new Padding(3, 4, 3, 4);
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
            IPBox.Size = new Size(455, 48);
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
            descBox.Location = new Point(15, 260);
            descBox.Margin = new Padding(3, 4, 3, 4);
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
            descBox.Size = new Size(455, 172);
            descBox.TabIndex = 5;
            descBox.TabStop = false;
            descBox.TextAlign = HorizontalAlignment.Left;
            descBox.UseSystemPasswordChar = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Depth = 0;
            deleteBtn.Icon = (Image)resources.GetObject("deleteBtn.Icon");
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(767, 517);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(64, 75);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "materialFloatingActionButton1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Depth = 0;
            addBtn.Icon = (Image)resources.GetObject("addBtn.Icon");
            addBtn.Location = new Point(488, 39);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(64, 75);
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
            searchBox.Location = new Point(15, 444);
            searchBox.Margin = new Padding(3, 4, 3, 4);
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
            searchBox.Size = new Size(731, 48);
            searchBox.TabIndex = 8;
            searchBox.TabStop = false;
            searchBox.TextAlign = HorizontalAlignment.Left;
            searchBox.TrailingIcon = null;
            searchBox.UseAccent = false;
            searchBox.UseSystemPasswordChar = false;
            // 
            // updateBtn
            // 
            updateBtn.AutoSize = false;
            updateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateBtn.Depth = 0;
            updateBtn.HighEmphasis = true;
            updateBtn.Icon = null;
            updateBtn.Location = new Point(753, 604);
            updateBtn.Margin = new Padding(5, 8, 5, 8);
            updateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateBtn.Name = "updateBtn";
            updateBtn.NoAccentTextColor = Color.Empty;
            updateBtn.Size = new Size(86, 48);
            updateBtn.TabIndex = 9;
            updateBtn.Text = "Update";
            updateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateBtn.UseAccentColor = false;
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // prntBtn
            // 
            prntBtn.AutoSize = false;
            prntBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            prntBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            prntBtn.Depth = 0;
            prntBtn.HighEmphasis = true;
            prntBtn.Icon = null;
            prntBtn.Location = new Point(754, 677);
            prntBtn.Margin = new Padding(5, 8, 5, 8);
            prntBtn.MouseState = MaterialSkin.MouseState.HOVER;
            prntBtn.Name = "prntBtn";
            prntBtn.NoAccentTextColor = Color.Empty;
            prntBtn.Size = new Size(86, 48);
            prntBtn.TabIndex = 10;
            prntBtn.Text = "Print";
            prntBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prntBtn.UseAccentColor = false;
            prntBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(475, 431);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding a patient";
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(14, 517);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.Name = "gridView";
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.Height = 25;
            gridView.Size = new Size(733, 343);
            gridView.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 877);
            Controls.Add(gridView);
            Controls.Add(prntBtn);
            Controls.Add(updateBtn);
            Controls.Add(searchBox);
            Controls.Add(addBtn);
            Controls.Add(deleteBtn);
            Controls.Add(descBox);
            Controls.Add(IPBox);
            Controls.Add(phoneBox);
            Controls.Add(lNameBox);
            Controls.Add(fNameBox);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 fNameBox;
        private MaterialSkin.Controls.MaterialTextBox2 lNameBox;
        private MaterialSkin.Controls.MaterialTextBox2 phoneBox;
        private MaterialSkin.Controls.MaterialTextBox2 IPBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 descBox;
        private MaterialSkin.Controls.MaterialFloatingActionButton deleteBtn;
        private MaterialSkin.Controls.MaterialFloatingActionButton addBtn;
        private MaterialSkin.Controls.MaterialTextBox2 searchBox;
        private MaterialSkin.Controls.MaterialButton updateBtn;
        private MaterialSkin.Controls.MaterialButton prntBtn;
        private GroupBox groupBox1;
        private DataGridView gridView;
    }
}