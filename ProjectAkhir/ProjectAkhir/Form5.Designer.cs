﻿namespace ProjectAkhir
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
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Image = global::ProjectAkhir.Properties.Resources.x1;
            this.button7.Location = new System.Drawing.Point(-1, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 28);
            this.button7.TabIndex = 75;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(520, 233);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 26);
            this.button9.TabIndex = 86;
            this.button9.Text = "BACK";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(590, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 26);
            this.button4.TabIndex = 87;
            this.button4.Text = "LOG OUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "SELAMAT BERKAS ANDA BERHASIL DIUPLOAD!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "KAMI AKAN MENGHUBUNGI ANDA SECEPATNYA.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAkhir.Properties.Resources.wisuda2;
            this.ClientSize = new System.Drawing.Size(683, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}