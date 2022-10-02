namespace SiparisYonetimi.WinFormsUI
{
    partial class UrunYonetimi
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbMarkalar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.chbDurum = new System.Windows.Forms.CheckBox();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtAdı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(13, 13);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(255, 20);
            this.txtAra.TabIndex = 0;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(13, 54);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(546, 478);
            this.dgvUrunler.TabIndex = 1;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbMarkalar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbKategoriler);
            this.groupBox1.Controls.Add(this.chbDurum);
            this.groupBox1.Controls.Add(this.txtResim);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtAdı);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(580, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 410);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(215, 358);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(120, 358);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(23, 358);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbMarkalar
            // 
            this.cbMarkalar.DisplayMember = "Name";
            this.cbMarkalar.FormattingEnabled = true;
            this.cbMarkalar.Location = new System.Drawing.Point(161, 274);
            this.cbMarkalar.Name = "cbMarkalar";
            this.cbMarkalar.Size = new System.Drawing.Size(121, 21);
            this.cbMarkalar.TabIndex = 14;
            this.cbMarkalar.ValueMember = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kategori";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DisplayMember = "name";
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(161, 241);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cbKategoriler.TabIndex = 11;
            this.cbKategoriler.ValueMember = "id";
            // 
            // chbDurum
            // 
            this.chbDurum.AutoSize = true;
            this.chbDurum.Location = new System.Drawing.Point(161, 202);
            this.chbDurum.Name = "chbDurum";
            this.chbDurum.Size = new System.Drawing.Size(57, 17);
            this.chbDurum.TabIndex = 10;
            this.chbDurum.Text = "Durum";
            this.chbDurum.UseVisualStyleBackColor = true;
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(161, 176);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(100, 20);
            this.txtResim.TabIndex = 9;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(161, 140);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 20);
            this.txtStok.TabIndex = 8;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(161, 107);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(161, 60);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 41);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(161, 34);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(100, 20);
            this.txtAdı.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(274, 10);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(88, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Filtrele";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // UrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 544);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.txtAra);
            this.Name = "UrunYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Yönetimi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UrunYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.UrunYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbDurum;
        private System.Windows.Forms.ComboBox cbMarkalar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}