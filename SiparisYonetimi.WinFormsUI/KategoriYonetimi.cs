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
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        CategoryManager manager = new CategoryManager();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = manager.GetAll();
           
        }
        void Temizle()
        {
            txtAciklama.Text = String.Empty;
           
            txtKategoriAdi.Text = String.Empty;
            chbDurum.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Gereklidir");
                return;
            }
            Category category = new Category();
            category.Name = txtKategoriAdi.Text;
            category.Description = txtAciklama.Text;
            category.IsActive = chbDurum.Checked;
            
            try
            {
                manager.Add(category);
                var sonuc = manager.SaveChanges(category);
                if (sonuc>0)
                {
                    Temizle();
                    dgvKategoriler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt başarılı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt başarısız");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
                Category kayit = manager.Find(id);
                txtAciklama.Text = kayit.Description;
                txtKategoriAdi.Text = kayit.Name;
                chbDurum.Checked=kayit.IsActive;

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
            var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
            Category kategori = manager.Find(id);

            kategori.Name = txtKategoriAdi.Text;
            kategori.IsActive = chbDurum.Checked;
            kategori.Description = txtAciklama.Text;

            try
            {
                manager.Update(kategori);
                var sonuc = manager.SaveChanges(kategori);
                if (sonuc>0)
                {
                    Temizle();
                    dgvKategoriler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt başarılı");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu"); 
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells[0].Value);
                Category kategori = manager.Find(id);
                manager.Delete(kategori);
                int sonuc = manager.SaveChanges(kategori);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvKategoriler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt başarılı");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = manager.GetAll((kategori => kategori.Name.Contains(txtAra.Text) || kategori.Description.Contains(txtAra.Text)));
        }
    }
}
