namespace SiparisYonetimi.WinFormsUI
{
    partial class KullanıcıYonetimi
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
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.KullaniciBilgileri = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyAdi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.chbDurum = new System.Windows.Forms.CheckBox();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.KullaniciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 49);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.Size = new System.Drawing.Size(420, 389);
            this.dgvKullanicilar.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(324, 20);
            this.txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(342, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(90, 20);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // KullaniciBilgileri
            // 
            this.KullaniciBilgileri.Controls.Add(this.chbAdmin);
            this.KullaniciBilgileri.Controls.Add(this.chbDurum);
            this.KullaniciBilgileri.Controls.Add(this.btnSil);
            this.KullaniciBilgileri.Controls.Add(this.btnGuncelle);
            this.KullaniciBilgileri.Controls.Add(this.btnEkle);
            this.KullaniciBilgileri.Controls.Add(this.txtSifre);
            this.KullaniciBilgileri.Controls.Add(this.txtKullaniciAdi);
            this.KullaniciBilgileri.Controls.Add(this.txtTelefon);
            this.KullaniciBilgileri.Controls.Add(this.txtEmail);
            this.KullaniciBilgileri.Controls.Add(this.txtSoyAdi);
            this.KullaniciBilgileri.Controls.Add(this.txtAdi);
            this.KullaniciBilgileri.Controls.Add(this.label6);
            this.KullaniciBilgileri.Controls.Add(this.label5);
            this.KullaniciBilgileri.Controls.Add(this.label4);
            this.KullaniciBilgileri.Controls.Add(this.label3);
            this.KullaniciBilgileri.Controls.Add(this.label2);
            this.KullaniciBilgileri.Controls.Add(this.txt);
            this.KullaniciBilgileri.Location = new System.Drawing.Point(468, 49);
            this.KullaniciBilgileri.Name = "KullaniciBilgileri";
            this.KullaniciBilgileri.Size = new System.Drawing.Size(320, 389);
            this.KullaniciBilgileri.TabIndex = 3;
            this.KullaniciBilgileri.TabStop = false;
            this.KullaniciBilgileri.Text = "Kullanicı Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(219, 275);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(119, 275);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(19, 275);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(137, 164);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 12;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(137, 138);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(137, 108);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSoyAdi
            // 
            this.txtSoyAdi.Location = new System.Drawing.Point(137, 49);
            this.txtSoyAdi.Name = "txtSoyAdi";
            this.txtSoyAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyAdi.TabIndex = 8;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(137, 21);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soy Adı";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(6, 28);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(22, 13);
            this.txt.TabIndex = 0;
            this.txt.Text = "Adı";
            // 
            // chbDurum
            // 
            this.chbDurum.AutoSize = true;
            this.chbDurum.Location = new System.Drawing.Point(137, 203);
            this.chbDurum.Name = "chbDurum";
            this.chbDurum.Size = new System.Drawing.Size(57, 17);
            this.chbDurum.TabIndex = 16;
            this.chbDurum.Text = "Durum";
            this.chbDurum.UseVisualStyleBackColor = true;
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.Location = new System.Drawing.Point(137, 238);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(55, 17);
            this.chbAdmin.TabIndex = 17;
            this.chbAdmin.Text = "Admin";
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // KullanıcıYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KullaniciBilgileri);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "KullanıcıYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yonetimi";
            this.Load += new System.EventHandler(this.KullanıcıYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.KullaniciBilgileri.ResumeLayout(false);
            this.KullaniciBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox KullaniciBilgileri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chbAdmin;
        private System.Windows.Forms.CheckBox chbDurum;
    }
}