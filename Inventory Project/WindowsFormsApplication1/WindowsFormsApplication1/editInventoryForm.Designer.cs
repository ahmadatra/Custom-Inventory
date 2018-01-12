namespace WindowsFormsApplication1
{
    partial class editInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editInventoryForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Console = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.ConsoleSelectorBox = new System.Windows.Forms.ComboBox();
            this.SelectorBox = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ChangeQuantityTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.ConsoleLabel2 = new System.Windows.Forms.Label();
            this.TitleTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConsoleSelectorBox2 = new System.Windows.Forms.ComboBox();
            this.UpdateQuantityButton = new System.Windows.Forms.Button();
            this.AddGameButton = new System.Windows.Forms.Button();
            this.AddGameQuantityLabel = new System.Windows.Forms.Label();
            this.AddGameQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.ViewInventoryButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInventoryToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewInventoryToolStripMenuItem
            // 
            this.viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            this.viewInventoryToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.viewInventoryToolStripMenuItem.Text = "View Inventory";
            this.viewInventoryToolStripMenuItem.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.closeApplicationToolStripMenuItem.Text = "Exit";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Console,
            this.Title,
            this.Quantity});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 377);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(855, 509);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 100;
            // 
            // Console
            // 
            this.Console.Text = "Console";
            this.Console.Width = 150;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 100;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(109, 135);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(393, 29);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 135);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(60, 25);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title: ";
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(12, 192);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(91, 25);
            this.ConsoleLabel.TabIndex = 4;
            this.ConsoleLabel.Text = "Console:";
            // 
            // ConsoleSelectorBox
            // 
            this.ConsoleSelectorBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConsoleSelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsoleSelectorBox.FormattingEnabled = true;
            this.ConsoleSelectorBox.Items.AddRange(new object[] {
            "",
            "GBA",
            "GBC",
            "GC",
            "PS1",
            "PS2",
            "PS3",
            "XBOX",
            "X360"});
            this.ConsoleSelectorBox.Location = new System.Drawing.Point(111, 192);
            this.ConsoleSelectorBox.Name = "ConsoleSelectorBox";
            this.ConsoleSelectorBox.Size = new System.Drawing.Size(391, 32);
            this.ConsoleSelectorBox.TabIndex = 5;
            this.ConsoleSelectorBox.SelectedIndexChanged += new System.EventHandler(this.ConsoleSelectorBox_SelectedIndexChanged);
            // 
            // SelectorBox
            // 
            this.SelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectorBox.FormattingEnabled = true;
            this.SelectorBox.Items.AddRange(new object[] {
            "",
            "Update Quantity",
            "Add Game"});
            this.SelectorBox.Location = new System.Drawing.Point(12, 41);
            this.SelectorBox.Name = "SelectorBox";
            this.SelectorBox.Size = new System.Drawing.Size(251, 32);
            this.SelectorBox.TabIndex = 10;
            this.SelectorBox.SelectedIndexChanged += new System.EventHandler(this.SelectorBox_SelectedIndexChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(13, 251);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(91, 25);
            this.QuantityLabel.TabIndex = 11;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // ChangeQuantityTextBox
            // 
            this.ChangeQuantityTextBox.Location = new System.Drawing.Point(111, 251);
            this.ChangeQuantityTextBox.Name = "ChangeQuantityTextBox";
            this.ChangeQuantityTextBox.Size = new System.Drawing.Size(391, 29);
            this.ChangeQuantityTextBox.TabIndex = 12;
            this.ChangeQuantityTextBox.TextChanged += new System.EventHandler(this.ADDQuantityTextBox_TextChanged);
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Location = new System.Drawing.Point(642, 135);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(60, 25);
            this.TitleLabel2.TabIndex = 13;
            this.TitleLabel2.Text = "Title: ";
            // 
            // ConsoleLabel2
            // 
            this.ConsoleLabel2.AutoSize = true;
            this.ConsoleLabel2.Location = new System.Drawing.Point(642, 192);
            this.ConsoleLabel2.Name = "ConsoleLabel2";
            this.ConsoleLabel2.Size = new System.Drawing.Size(96, 25);
            this.ConsoleLabel2.TabIndex = 14;
            this.ConsoleLabel2.Text = "Console: ";
            // 
            // TitleTextBox2
            // 
            this.TitleTextBox2.Location = new System.Drawing.Point(750, 135);
            this.TitleTextBox2.Name = "TitleTextBox2";
            this.TitleTextBox2.Size = new System.Drawing.Size(375, 29);
            this.TitleTextBox2.TabIndex = 15;
            this.TitleTextBox2.TextChanged += new System.EventHandler(this.TitleTextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Change Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(641, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Add Game";
            // 
            // ConsoleSelectorBox2
            // 
            this.ConsoleSelectorBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConsoleSelectorBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsoleSelectorBox2.FormattingEnabled = true;
            this.ConsoleSelectorBox2.Items.AddRange(new object[] {
            "",
            "GBA",
            "GBC",
            "GC",
            "PS1",
            "PS2",
            "PS3",
            "XBOX",
            "X360"});
            this.ConsoleSelectorBox2.Location = new System.Drawing.Point(750, 192);
            this.ConsoleSelectorBox2.Name = "ConsoleSelectorBox2";
            this.ConsoleSelectorBox2.Size = new System.Drawing.Size(375, 32);
            this.ConsoleSelectorBox2.TabIndex = 19;
            this.ConsoleSelectorBox2.SelectedIndexChanged += new System.EventHandler(this.ConsoleSelectorBox2_SelectedIndexChanged);
            // 
            // UpdateQuantityButton
            // 
            this.UpdateQuantityButton.Location = new System.Drawing.Point(18, 304);
            this.UpdateQuantityButton.Name = "UpdateQuantityButton";
            this.UpdateQuantityButton.Size = new System.Drawing.Size(484, 67);
            this.UpdateQuantityButton.TabIndex = 20;
            this.UpdateQuantityButton.Text = "Update";
            this.UpdateQuantityButton.UseVisualStyleBackColor = true;
            this.UpdateQuantityButton.Click += new System.EventHandler(this.UpdateQuantityButton_Click);
            // 
            // AddGameButton
            // 
            this.AddGameButton.Location = new System.Drawing.Point(647, 304);
            this.AddGameButton.Name = "AddGameButton";
            this.AddGameButton.Size = new System.Drawing.Size(478, 67);
            this.AddGameButton.TabIndex = 21;
            this.AddGameButton.Text = "Add Game";
            this.AddGameButton.UseVisualStyleBackColor = true;
            this.AddGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // AddGameQuantityLabel
            // 
            this.AddGameQuantityLabel.AutoSize = true;
            this.AddGameQuantityLabel.Location = new System.Drawing.Point(642, 251);
            this.AddGameQuantityLabel.Name = "AddGameQuantityLabel";
            this.AddGameQuantityLabel.Size = new System.Drawing.Size(91, 25);
            this.AddGameQuantityLabel.TabIndex = 22;
            this.AddGameQuantityLabel.Text = "Quantity:";
            // 
            // AddGameQuantityTextBox
            // 
            this.AddGameQuantityTextBox.Location = new System.Drawing.Point(750, 251);
            this.AddGameQuantityTextBox.Name = "AddGameQuantityTextBox";
            this.AddGameQuantityTextBox.Size = new System.Drawing.Size(375, 29);
            this.AddGameQuantityTextBox.TabIndex = 23;
            this.AddGameQuantityTextBox.TextChanged += new System.EventHandler(this.AddGameQuantityTextBox_TextChanged);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllButton.Location = new System.Drawing.Point(875, 731);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(250, 155);
            this.ClearAllButton.TabIndex = 24;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // ViewInventoryButton
            // 
            this.ViewInventoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewInventoryButton.Location = new System.Drawing.Point(484, 892);
            this.ViewInventoryButton.Name = "ViewInventoryButton";
            this.ViewInventoryButton.Size = new System.Drawing.Size(641, 64);
            this.ViewInventoryButton.TabIndex = 25;
            this.ViewInventoryButton.Text = "View Inventory";
            this.ViewInventoryButton.UseVisualStyleBackColor = true;
            this.ViewInventoryButton.Click += new System.EventHandler(this.ViewInventoryButton_Click);
            // 
            // editInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 968);
            this.Controls.Add(this.ViewInventoryButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.AddGameQuantityTextBox);
            this.Controls.Add(this.AddGameQuantityLabel);
            this.Controls.Add(this.AddGameButton);
            this.Controls.Add(this.UpdateQuantityButton);
            this.Controls.Add(this.ConsoleSelectorBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTextBox2);
            this.Controls.Add(this.ConsoleLabel2);
            this.Controls.Add(this.TitleLabel2);
            this.Controls.Add(this.ChangeQuantityTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.SelectorBox);
            this.Controls.Add(this.ConsoleSelectorBox);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "editInventoryForm";
            this.Text = "editInventoryForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.ComboBox ConsoleSelectorBox;
        private System.Windows.Forms.ComboBox SelectorBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox ChangeQuantityTextBox;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Label ConsoleLabel2;
        private System.Windows.Forms.TextBox TitleTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ConsoleSelectorBox2;
        private System.Windows.Forms.Button UpdateQuantityButton;
        private System.Windows.Forms.Button AddGameButton;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Console;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Label AddGameQuantityLabel;
        private System.Windows.Forms.TextBox AddGameQuantityTextBox;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button ViewInventoryButton;
    }
}