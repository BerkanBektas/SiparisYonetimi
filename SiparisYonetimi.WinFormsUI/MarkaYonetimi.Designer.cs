﻿namespace SiparisYonetimi.WinFormsUI
{
    partial class MarkaYonetimi
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
            this.dgvMarkalar = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chbDurum = new System.Windows.Forms.CheckBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.txtMarkaAdı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarkalar
            // 
            this.dgvMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkalar.Location = new System.Drawing.Point(12, 52);
            this.dgvMarkalar.Name = "dgvMarkalar";
            this.dgvMarkalar.Size = new System.Drawing.Size(414, 386);
            this.dgvMarkalar.TabIndex = 0;
            this.dgvMarkalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkalar_CellClick);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(13, 13);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(274, 20);
            this.txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(316, 9);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(110, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chbDurum);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtLogo);
            this.groupBox1.Controls.Add(this.txtMarkaAdı);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(505, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 386);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(184, 192);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(103, 192);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(22, 192);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chbDurum
            // 
            this.chbDurum.AutoSize = true;
            this.chbDurum.Location = new System.Drawing.Point(89, 141);
            this.chbDurum.Name = "chbDurum";
            this.chbDurum.Size = new System.Drawing.Size(57, 17);
            this.chbDurum.TabIndex = 6;
            this.chbDurum.Text = "Durum";
            this.chbDurum.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(22, 260);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(237, 99);
            this.txtAciklama.TabIndex = 5;
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(133, 75);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(100, 20);
            this.txtLogo.TabIndex = 4;
            // 
            // txtMarkaAdı
            // 
            this.txtMarkaAdı.Location = new System.Drawing.Point(133, 41);
            this.txtMarkaAdı.Name = "txtMarkaAdı";
            this.txtMarkaAdı.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaAdı.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MarkaAdı";
            // 
            // MarkaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgvMarkalar);
            this.Name = "MarkaYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Yönetimi";
            this.Load += new System.EventHandler(this.MarkaYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarkalar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbDurum;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.TextBox txtMarkaAdı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}