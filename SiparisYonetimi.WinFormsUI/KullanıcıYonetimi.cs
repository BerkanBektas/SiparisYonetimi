using SiparisYonetimi.Business.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiparisYonetimi.Entities;

namespace SiparisYonetimi.WinFormsUI
{
    public partial class KullanıcıYonetimi : Form
    {
        public KullanıcıYonetimi()
        {
            InitializeComponent();
        }
        UserManager manager = new UserManager();

        private void KullanıcıYonetimi_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll();

        }
        void Temizle()
        {
            txtAdi.Text = String.Empty;
            txtAra.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtKullaniciAdi.Text = String.Empty;
            txtSifre.Text = String.Empty;
            txtSoyAdi.Text = String.Empty;
            txtTelefon.Text = String.Empty;
            chbAdmin.Checked = false;
            chbDurum.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtAdi.Text;
            user.Email = txtEmail.Text;
            user.Surname = txtSoyAdi.Text;
            user.Phone = txtTelefon.Text;
            user.IsActive = chbDurum.Checked;
            user.IsAdmin = chbAdmin.Checked;
            user.Username = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;


            var sonuc = manager.Add(user);

            if (sonuc > 0)//Sonuç 0'dan büyükse ekleme başarılı
            {
                Temizle();
                dgvKullanicilar.DataSource = manager.GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);
                User kayit = manager.Find(id);
                int sonuc = manager.Remove(kayit);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvKullanicilar.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Silindi");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Silinemedi!!!");
            }

        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);
                User kayit = manager.Find(id);
                txtAdi.Text = kayit.Name;
                txtEmail.Text = kayit.Email;
                txtSoyAdi.Text = kayit.Surname;
                txtTelefon.Text = kayit.Phone;
                txtSifre.Text = kayit.Password;
                txtKullaniciAdi.Text = kayit.Username;
                chbAdmin.Checked = kayit.IsAdmin;
                chbDurum.Checked = kayit.IsActive;


                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Başarısız");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKullanicilar.CurrentRow.Cells[0].Value);

            User user = manager.Find(id);

            user.Name = txtAdi.Text;
            user.Email = txtEmail.Text;
            user.Surname = txtSoyAdi.Text;
            user.Phone = txtTelefon.Text;
            user.IsActive = chbDurum.Checked;
            user.IsAdmin = chbAdmin.Checked;
            user.Username = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;



            var sonuc = manager.Update(user);

            if (sonuc > 0)//Sonuç 0'dan büyükse ekleme başarılı
            {
                Temizle();
                dgvKullanicilar.DataSource = manager.GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll(txtAra.Text);
        }
    }
}
