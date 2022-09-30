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
    public partial class UrunYonetimi : Form
    {
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
                chbDurum.Checked = false;
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                txtAra.Text = String.Empty;
            }
        }
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        ProductManager manager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();
        BrandManager brandManager = new BrandManager();

        void Yukle()
        {
            dgvUrunler.DataSource = manager.GetAll();
            cbKategoriler.DataSource = categoryManager.GetAll();
            cbMarkalar.DataSource = brandManager.GetAll();
        }

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kontrol();
            try
            {
                Product urun = new Product();
                urun.Name = txtAdı.Text;
                urun.Description = txtAciklama.Text;
                urun.Stock = int.Parse(txtStok.Text);
                urun.Price = Convert.ToDecimal(txtFiyat.Text);
                urun.BrandId = (int)cbMarkalar.SelectedValue;
                urun.CategoryId = (int)cbKategoriler.SelectedValue;
                urun.Image = txtResim.Text;
                urun.IsActive = chbDurum.Checked;

                manager.Add(urun);
                
                int sonuc = manager.SaveChanges(urun);
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    dgvUrunler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Başarılı!!");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dgvUrunler.CurrentRow.Cells[0].Value;
                var urun = manager.Find(id);
                txtAdı.Text=urun.Name;
                txtAciklama.Text = urun.Description;
                txtFiyat.Text = urun.Price.ToString();
                txtResim.Text = urun.Image;
                txtStok.Text = urun.Stock.ToString();
                chbDurum.Checked = urun.IsActive;
                cbKategoriler.SelectedValue = urun.CategoryId;
                cbMarkalar.SelectedValue = urun.BrandId;
                btnSil.Enabled = true;
                btnGuncelle.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!!");
            }
        }
        void Kontrol()
        {
            if (string.IsNullOrWhiteSpace(txtAdı.Text) )
            {
                MessageBox.Show("Ürün adı boş geçilemez!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFiyat.Text) )
            {
                MessageBox.Show("Fiyat boş geçilemez!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStok.Text) )
            {
                MessageBox.Show("Stok boş geçilemez!");
                return;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kontrol();   
            try
            {
                int id = (int)dgvUrunler.CurrentRow.Cells[0].Value;
                var urun = manager.Find(id);

                urun.Name = txtAdı.Text;
                urun.Description = txtAciklama.Text;
                urun.Stock = int.Parse(txtStok.Text);
                urun.Price = Convert.ToDecimal(txtFiyat.Text);
                urun.BrandId = (int)cbMarkalar.SelectedValue;
                urun.CategoryId = (int)cbKategoriler.SelectedValue;
                urun.Image = txtResim.Text;
                urun.IsActive = chbDurum.Checked;

                manager.Update(urun);

                int sonuc = manager.SaveChanges(urun);
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    dgvUrunler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Başarılı!!");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
            var kayit = manager.Find(id);
            try
            {
                manager.Delete(kayit);
                int sonuc = manager.SaveChanges(kayit);
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    dgvUrunler.DataSource = manager.GetAll();
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
            dgvUrunler.DataSource = manager.GetAll(m => m.Name.Contains(txtAra.Text)|| m.Description.Contains(txtAra.Text));
        }
    }
}
