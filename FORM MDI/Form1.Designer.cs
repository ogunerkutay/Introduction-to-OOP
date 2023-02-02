namespace FORM_MDI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.form2GösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2KapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2GösterToolStripMenuItem,
            this.form2KapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // form2GösterToolStripMenuItem
            // 
            this.form2GösterToolStripMenuItem.Name = "form2GösterToolStripMenuItem";
            this.form2GösterToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.form2GösterToolStripMenuItem.Text = "Form2 Göster";
            this.form2GösterToolStripMenuItem.Click += new System.EventHandler(this.form2GösterToolStripMenuItem_Click);
            // 
            // form2KapatToolStripMenuItem
            // 
            this.form2KapatToolStripMenuItem.Name = "form2KapatToolStripMenuItem";
            this.form2KapatToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.form2KapatToolStripMenuItem.Text = "Form2 Kapat";
            this.form2KapatToolStripMenuItem.Click += new System.EventHandler(this.form2KapatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form2GösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2KapatToolStripMenuItem;
    }
}

