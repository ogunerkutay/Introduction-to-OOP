namespace DirectoryAndFileSample
{
    partial class FolderListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.listViewFolderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.buttonListFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klasör Seçiniz";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Enabled = false;
            this.textBoxFolderPath.Location = new System.Drawing.Point(140, 14);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(405, 27);
            this.textBoxFolderPath.TabIndex = 1;
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Location = new System.Drawing.Point(551, 12);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(47, 29);
            this.buttonChooseFolder.TabIndex = 2;
            this.buttonChooseFolder.Text = "...";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            // 
            // listViewFolderList
            // 
            this.listViewFolderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewFolderList.FullRowSelect = true;
            this.listViewFolderList.GridLines = true;
            this.listViewFolderList.HideSelection = false;
            this.listViewFolderList.Location = new System.Drawing.Point(18, 82);
            this.listViewFolderList.Name = "listViewFolderList";
            this.listViewFolderList.Size = new System.Drawing.Size(770, 356);
            this.listViewFolderList.TabIndex = 3;
            this.listViewFolderList.UseCompatibleStateImageBehavior = false;
            this.listViewFolderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Folder Path";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 100;
            // 
            // buttonListFolder
            // 
            this.buttonListFolder.Location = new System.Drawing.Point(383, 47);
            this.buttonListFolder.Name = "buttonListFolder";
            this.buttonListFolder.Size = new System.Drawing.Size(94, 29);
            this.buttonListFolder.TabIndex = 4;
            this.buttonListFolder.Text = "Klasör Listesi";
            this.buttonListFolder.UseVisualStyleBackColor = true;
            // 
            // FolderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListFolder);
            this.Controls.Add(this.listViewFolderList);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.label1);
            this.Name = "FolderListForm";
            this.Text = "Folder List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.ListView listViewFolderList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonListFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}