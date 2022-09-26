using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetimi.WinFormsUI
{
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtAciklama.Text = String.Empty;
            txtLogo.Text = String.Empty;
            txtMarkaAdı.Text = String.Empty;
            chbDurum.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        BrandManager manager = new BrandManager();

        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            dgvMarkalar.DataSource = manager.GetAll();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarkaAdı.Text))
            {
                MessageBox.Show("Marka Adı Giriniz!");
                return;
            }
            Brand brand = new Brand()
            {
                Description = txtAciklama.Text,
                IsActive = chbDurum.Checked,
                Logo = txtLogo.Text,
                Name = txtMarkaAdı.Text,

            };
            try
            {
                manager.Add(brand);
                int sonuc = manager.SaveChanges(brand);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvMarkalar.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Başarılı!!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
            
            

        }

        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id =Convert.ToInt32(dgvMarkalar.CurrentRow.Cells[0].Value);
                var kayit = manager.Find(id);
                txtAciklama.Text=kayit.Description;
                txtMarkaAdı.Text = kayit.Name;
                txtLogo.Text = kayit.Logo;
                chbDurum.Checked = kayit.IsActive;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarkaAdı.Text))
            {
                MessageBox.Show("Marka Adı Giriniz!");
                return;
            }
            int id = Convert.ToInt32(dgvMarkalar.CurrentRow.Cells[0].Value);
            Brand brand = manager.Find(id);
            brand.Name = txtMarkaAdı.Text;
            brand.Logo = txtLogo.Text;
            brand.IsActive = chbDurum.Checked;
            brand.Description = txtAciklama.Text;
            try
            {
                manager.Update(brand);
                int sonuc = manager.SaveChanges(brand);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvMarkalar.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");

            }
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvMarkalar.CurrentRow.Cells[0].Value);
            Brand brand = manager.Find(id);
            try
            {
                manager.Delete(brand);
                int sonuc = manager.SaveChanges(brand);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvMarkalar.DataSource = manager.GetAll();
                    MessageBox.Show("Silme Başarılı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");

            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvMarkalar.DataSource =manager.GetAll(brand => brand.Name.Contains(txtAra.Text)||brand.Logo.Contains(txtAra.Text));
        }
    }
}

