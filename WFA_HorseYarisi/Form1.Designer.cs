﻿namespace WFA_HorseYarisi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.btnYarisiBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFinishCizgisi = new System.Windows.Forms.Label();
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1673, 10);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1673, 10);
            this.label2.TabIndex = 0;
            // 
            // pc3
            // 
            this.pc3.Image = global::WFA_HorseYarisi.Properties.Resources.horse5;
            this.pc3.Location = new System.Drawing.Point(0, 149);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(279, 168);
            this.pc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc3.TabIndex = 1;
            this.pc3.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.Image = global::WFA_HorseYarisi.Properties.Resources.horse3;
            this.pc2.Location = new System.Drawing.Point(0, 353);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(279, 168);
            this.pc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc2.TabIndex = 1;
            this.pc2.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.Image = global::WFA_HorseYarisi.Properties.Resources.horse1;
            this.pc1.Location = new System.Drawing.Point(0, 556);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(279, 168);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc1.TabIndex = 1;
            this.pc1.TabStop = false;
            // 
            // btnYarisiBaslat
            // 
            this.btnYarisiBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYarisiBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYarisiBaslat.ForeColor = System.Drawing.Color.White;
            this.btnYarisiBaslat.Location = new System.Drawing.Point(1404, 12);
            this.btnYarisiBaslat.Name = "btnYarisiBaslat";
            this.btnYarisiBaslat.Size = new System.Drawing.Size(401, 67);
            this.btnYarisiBaslat.TabIndex = 2;
            this.btnYarisiBaslat.Text = "Yarışı Başlat";
            this.btnYarisiBaslat.UseVisualStyleBackColor = true;
            this.btnYarisiBaslat.Click += new System.EventHandler(this.btnYarisiBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFinishCizgisi
            // 
            this.lblFinishCizgisi.BackColor = System.Drawing.Color.White;
            this.lblFinishCizgisi.Location = new System.Drawing.Point(1663, 124);
            this.lblFinishCizgisi.Name = "lblFinishCizgisi";
            this.lblFinishCizgisi.Size = new System.Drawing.Size(10, 600);
            this.lblFinishCizgisi.TabIndex = 3;
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.AutoSize = true;
            this.lblBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilgilendirme.ForeColor = System.Drawing.Color.White;
            this.lblBilgilendirme.Location = new System.Drawing.Point(31, 22);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(0, 25);
            this.lblBilgilendirme.TabIndex = 4;
            // 
            // btnSifirla
            // 
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifirla.Location = new System.Drawing.Point(997, 12);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(401, 67);
            this.btnSifirla.TabIndex = 5;
            this.btnSifirla.Text = "Yarışı Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1817, 725);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.lblBilgilendirme);
            this.Controls.Add(this.lblFinishCizgisi);
            this.Controls.Add(this.btnYarisiBaslat);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.Button btnYarisiBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFinishCizgisi;
        private System.Windows.Forms.Label lblBilgilendirme;
        private System.Windows.Forms.Button btnSifirla;
    }
}

