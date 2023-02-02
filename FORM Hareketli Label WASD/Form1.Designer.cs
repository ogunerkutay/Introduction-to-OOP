namespace FORM_Hareketli_Label_WASD
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
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonHareketli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonW
            // 
            this.buttonW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonW.Location = new System.Drawing.Point(172, 301);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(50, 50);
            this.buttonW.TabIndex = 0;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonA
            // 
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonA.Location = new System.Drawing.Point(116, 330);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(50, 50);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonS
            // 
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonS.Location = new System.Drawing.Point(172, 349);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(50, 50);
            this.buttonS.TabIndex = 2;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonD.Location = new System.Drawing.Point(228, 330);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(50, 50);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonHareketli
            // 
            this.buttonHareketli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonHareketli.Location = new System.Drawing.Point(494, 150);
            this.buttonHareketli.Name = "buttonHareketli";
            this.buttonHareketli.Size = new System.Drawing.Size(50, 50);
            this.buttonHareketli.TabIndex = 4;
            this.buttonHareketli.TabStop = false;
            this.buttonHareketli.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHareketli);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonHareketli;
    }
}

