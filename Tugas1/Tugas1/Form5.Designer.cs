namespace Tugas1
{
    partial class Form5
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
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnGantiFont = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(211, 136);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(67, 24);
            this.btnKeluar.TabIndex = 5;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // btnGantiFont
            // 
            this.btnGantiFont.Location = new System.Drawing.Point(76, 136);
            this.btnGantiFont.Name = "btnGantiFont";
            this.btnGantiFont.Size = new System.Drawing.Size(67, 24);
            this.btnGantiFont.TabIndex = 4;
            this.btnGantiFont.Text = "Ganti Font";
            this.btnGantiFont.UseVisualStyleBackColor = true;
            this.btnGantiFont.Click += new System.EventHandler(this.btnGantiFont_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(163, 98);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(139, 23);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Hello World";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlgFont
            // 
            this.dlgFont.ShowApply = true;
            this.dlgFont.ShowColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 265);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnGantiFont);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form5";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnGantiFont;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}