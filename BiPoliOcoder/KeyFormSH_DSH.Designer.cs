namespace BiPoliOcoder
{
    partial class KeyFormSH_DSH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyFormSH_DSH));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secretbuttonOK = new System.Windows.Forms.Button();
            this.secrettextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BiPoliOcoder.Properties.Resources.eddy;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // secretbuttonOK
            // 
            resources.ApplyResources(this.secretbuttonOK, "secretbuttonOK");
            this.secretbuttonOK.Name = "secretbuttonOK";
            this.secretbuttonOK.UseVisualStyleBackColor = true;
            this.secretbuttonOK.Click += new System.EventHandler(this.secretbuttonOK_Click);
            // 
            // secrettextBox
            // 
            resources.ApplyResources(this.secrettextBox, "secrettextBox");
            this.secrettextBox.Name = "secrettextBox";
            this.secrettextBox.UseSystemPasswordChar = true;
            this.secrettextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEnterOK);
            // 
            // KeyFormSH_DSH
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secrettextBox);
            this.Controls.Add(this.secretbuttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KeyFormSH_DSH";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button secretbuttonOK;
        private System.Windows.Forms.TextBox secrettextBox;
    }
}