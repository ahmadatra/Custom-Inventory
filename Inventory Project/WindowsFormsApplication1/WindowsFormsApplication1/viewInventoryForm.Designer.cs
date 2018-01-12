namespace WindowsFormsApplication1
{
    partial class viewInventoryForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewInventoryForm));
            this.loadDatabase = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SwitchToEdit = new System.Windows.Forms.Button();
            this.ConsoleSelectorBox = new System.Windows.Forms.ComboBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SortSelectorBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitlelistView1 = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConsoleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTYHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalTitleslistView1 = new System.Windows.Forms.ListView();
            this.ConsoleListViewRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalListViewRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadDatabase
            // 
            this.loadDatabase.Location = new System.Drawing.Point(12, 56);
            this.loadDatabase.Name = "loadDatabase";
            this.loadDatabase.Size = new System.Drawing.Size(203, 152);
            this.loadDatabase.TabIndex = 0;
            this.loadDatabase.Text = "Load Inventory";
            this.loadDatabase.UseVisualStyleBackColor = true;
            this.loadDatabase.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(1277, 56);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 68);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(222, 56);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(1051, 29);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SwitchToEdit
            // 
            this.SwitchToEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchToEdit.Location = new System.Drawing.Point(475, 920);
            this.SwitchToEdit.Name = "SwitchToEdit";
            this.SwitchToEdit.Size = new System.Drawing.Size(913, 52);
            this.SwitchToEdit.TabIndex = 4;
            this.SwitchToEdit.Text = "Edit Inventory";
            this.SwitchToEdit.UseVisualStyleBackColor = true;
            this.SwitchToEdit.Click += new System.EventHandler(this.SwitchToEdit_Click);
            // 
            // ConsoleSelectorBox
            // 
            this.ConsoleSelectorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleSelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsoleSelectorBox.FormattingEnabled = true;
            this.ConsoleSelectorBox.Location = new System.Drawing.Point(223, 108);
            this.ConsoleSelectorBox.Name = "ConsoleSelectorBox";
            this.ConsoleSelectorBox.Size = new System.Drawing.Size(1050, 32);
            this.ConsoleSelectorBox.TabIndex = 5;
            this.ConsoleSelectorBox.SelectedIndexChanged += new System.EventHandler(this.ConsoleComboBox_SelectedIndexChanged);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(1277, 130);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(111, 64);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SortSelectorBox
            // 
            this.SortSelectorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortSelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortSelectorBox.FormattingEnabled = true;
            this.SortSelectorBox.Location = new System.Drawing.Point(221, 162);
            this.SortSelectorBox.Name = "SortSelectorBox";
            this.SortSelectorBox.Size = new System.Drawing.Size(1050, 32);
            this.SortSelectorBox.TabIndex = 7;
            this.SortSelectorBox.SelectedIndexChanged += new System.EventHandler(this.SortSelectorBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 38);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TitlelistView1
            // 
            this.TitlelistView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TitlelistView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.ConsoleHeader,
            this.TitleHeader,
            this.QTYHeader});
            this.TitlelistView1.FullRowSelect = true;
            this.TitlelistView1.GridLines = true;
            this.TitlelistView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.TitlelistView1.Location = new System.Drawing.Point(12, 214);
            this.TitlelistView1.Name = "TitlelistView1";
            this.TitlelistView1.Size = new System.Drawing.Size(991, 700);
            this.TitlelistView1.TabIndex = 9;
            this.TitlelistView1.UseCompatibleStateImageBehavior = false;
            this.TitlelistView1.View = System.Windows.Forms.View.Details;
            this.TitlelistView1.SelectedIndexChanged += new System.EventHandler(this.TitlelistView1_SelectedIndexChanged);
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            this.IDHeader.Width = 100;
            // 
            // ConsoleHeader
            // 
            this.ConsoleHeader.Text = "Console";
            this.ConsoleHeader.Width = 100;
            // 
            // TitleHeader
            // 
            this.TitleHeader.Text = "Title";
            this.TitleHeader.Width = 250;
            // 
            // QTYHeader
            // 
            this.QTYHeader.Text = "Quantity";
            this.QTYHeader.Width = 250;
            // 
            // TotalTitleslistView1
            // 
            this.TotalTitleslistView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalTitleslistView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConsoleListViewRight,
            this.TotalListViewRight});
            this.TotalTitleslistView1.FullRowSelect = true;
            this.TotalTitleslistView1.GridLines = true;
            this.TotalTitleslistView1.Location = new System.Drawing.Point(1009, 214);
            this.TotalTitleslistView1.Name = "TotalTitleslistView1";
            this.TotalTitleslistView1.Size = new System.Drawing.Size(379, 700);
            this.TotalTitleslistView1.TabIndex = 10;
            this.TotalTitleslistView1.UseCompatibleStateImageBehavior = false;
            this.TotalTitleslistView1.View = System.Windows.Forms.View.Details;
            // 
            // ConsoleListViewRight
            // 
            this.ConsoleListViewRight.Text = "Console";
            this.ConsoleListViewRight.Width = 100;
            // 
            // TotalListViewRight
            // 
            this.TotalListViewRight.Text = "Total";
            this.TotalListViewRight.Width = 100;
            // 
            // viewInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 984);
            this.Controls.Add(this.TotalTitleslistView1);
            this.Controls.Add(this.TitlelistView1);
            this.Controls.Add(this.SortSelectorBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ConsoleSelectorBox);
            this.Controls.Add(this.SwitchToEdit);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.loadDatabase);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "viewInventoryForm";
            this.Text = "viewInventoryForm";
            this.Load += new System.EventHandler(this.viewInventoryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadDatabase;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SwitchToEdit;
        private System.Windows.Forms.ComboBox ConsoleSelectorBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox SortSelectorBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView TitlelistView1;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader ConsoleHeader;
        private System.Windows.Forms.ColumnHeader TitleHeader;
        private System.Windows.Forms.ColumnHeader QTYHeader;
        private System.Windows.Forms.ListView TotalTitleslistView1;
        private System.Windows.Forms.ColumnHeader ConsoleListViewRight;
        private System.Windows.Forms.ColumnHeader TotalListViewRight;
    }
}