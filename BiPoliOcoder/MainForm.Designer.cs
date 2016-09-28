namespace BiPoliOcoder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.shyfrobutton = new System.Windows.Forms.Button();
            this.deshyfrobutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RTFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.STTFtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EFPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndAutPictureBox = new System.Windows.Forms.PictureBox();
            this.IndCountLabel = new System.Windows.Forms.Label();
            this.IndNotAutPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndAutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndNotAutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shyfrobutton
            // 
            resources.ApplyResources(this.shyfrobutton, "shyfrobutton");
            this.shyfrobutton.Name = "shyfrobutton";
            this.shyfrobutton.UseVisualStyleBackColor = true;
            this.shyfrobutton.Click += new System.EventHandler(this.Shyfrobutton_Click);
            // 
            // deshyfrobutton
            // 
            resources.ApplyResources(this.deshyfrobutton, "deshyfrobutton");
            this.deshyfrobutton.Name = "deshyfrobutton";
            this.deshyfrobutton.UseVisualStyleBackColor = true;
            this.deshyfrobutton.Click += new System.EventHandler(this.Deshyfrobutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RTFFToolStripMenuItem,
            this.STTFtoolStripMenuItem1,
            this.toolStripSeparator1,
            this.EFPToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // RTFFToolStripMenuItem
            // 
            this.RTFFToolStripMenuItem.Name = "RTFFToolStripMenuItem";
            resources.ApplyResources(this.RTFFToolStripMenuItem, "RTFFToolStripMenuItem");
            this.RTFFToolStripMenuItem.Click += new System.EventHandler(this.ReadTextFromFileToolStripMenuItem_Click);
            // 
            // STTFtoolStripMenuItem1
            // 
            this.STTFtoolStripMenuItem1.Name = "STTFtoolStripMenuItem1";
            resources.ApplyResources(this.STTFtoolStripMenuItem1, "STTFtoolStripMenuItem1");
            this.STTFtoolStripMenuItem1.Click += new System.EventHandler(this.WriteTextToFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // EFPToolStripMenuItem
            // 
            this.EFPToolStripMenuItem.Name = "EFPToolStripMenuItem";
            resources.ApplyResources(this.EFPToolStripMenuItem, "EFPToolStripMenuItem");
            this.EFPToolStripMenuItem.Click += new System.EventHandler(this.ExitFromProgramToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            resources.ApplyResources(this.SettingsToolStripMenuItem, "SettingsToolStripMenuItem");
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            resources.ApplyResources(this.manualToolStripMenuItem, "manualToolStripMenuItem");
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.MainRichTextBox, "MainRichTextBox");
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.TextChanged += new System.EventHandler(this.MainRichTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click_1);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // IndAutPictureBox
            // 
            this.IndAutPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.IndAutPictureBox.Cursor = System.Windows.Forms.Cursors.Help;
            resources.ApplyResources(this.IndAutPictureBox, "IndAutPictureBox");
            this.IndAutPictureBox.Name = "IndAutPictureBox";
            this.IndAutPictureBox.TabStop = false;
            // 
            // IndCountLabel
            // 
            resources.ApplyResources(this.IndCountLabel, "IndCountLabel");
            this.IndCountLabel.BackColor = System.Drawing.SystemColors.Window;
            this.IndCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndCountLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.IndCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.IndCountLabel.Name = "IndCountLabel";
            this.IndCountLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // IndNotAutPictureBox
            // 
            this.IndNotAutPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.IndNotAutPictureBox.Cursor = System.Windows.Forms.Cursors.Help;
            resources.ApplyResources(this.IndNotAutPictureBox, "IndNotAutPictureBox");
            this.IndNotAutPictureBox.Name = "IndNotAutPictureBox";
            this.IndNotAutPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IndNotAutPictureBox);
            this.Controls.Add(this.IndCountLabel);
            this.Controls.Add(this.IndAutPictureBox);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deshyfrobutton);
            this.Controls.Add(this.shyfrobutton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IndAutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndNotAutPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shyfrobutton;
        private System.Windows.Forms.Button deshyfrobutton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RTFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EFPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem STTFtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        internal System.Windows.Forms.RichTextBox MainRichTextBox;
        private System.Windows.Forms.PictureBox IndAutPictureBox;
        private System.Windows.Forms.Label IndCountLabel;
        private System.Windows.Forms.PictureBox IndNotAutPictureBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

