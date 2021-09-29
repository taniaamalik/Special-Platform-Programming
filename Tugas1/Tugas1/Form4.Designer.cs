namespace Tugas1
{
    partial class Form4
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
            this.btnGanti = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.dlgWarna = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnGanti
            // 
            this.btnGanti.Location = new System.Drawing.Point(44, 112);
            this.btnGanti.Name = "btnGanti";
            this.btnGanti.Size = new System.Drawing.Size(108, 22);
            this.btnGanti.TabIndex = 5;
            this.btnGanti.Text = "Ganti Background";
            this.btnGanti.UseVisualStyleBackColor = true;
            this.btnGanti.Click += new System.EventHandler(this.btnGanti_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(182, 112);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(100, 22);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 246);
            this.Controls.Add(this.btnGanti);
            this.Controls.Add(this.btnKeluar);
            this.Name = "Form4";
            this.Text = "Tugas 1 PPK-175150201111053";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGanti;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.ColorDialog dlgWarna;
    }
}