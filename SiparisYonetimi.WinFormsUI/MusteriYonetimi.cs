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
    public partial class MusteriYonetimi : Form
    {
        //void Temizle()
        //{
        //    txtAdi.Text = String.Empty;
        //    txtAdres.Text = String.Empty;
        //    txtAra.Text = String.Empty;
        //    txtEmail.Text = String.Empty;
        //    txtSoyadi.Text = String.Empty;
        //    txtTelefon.Text = String.Empty;
        //    chbDurum.Checked = false;
        //    btnGuncelle.Enabled = false;
        //    btnSil.Enabled = false;
        //}
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
                chbDurum.Checked=false;
                btnGuncelle.Enabled=false;
                btnSil.Enabled=false;
                txtAra.Text = String.Empty;
            }
        }
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        CustomerManager manager = new CustomerManager();
        private void MusteriYonetimi_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = manager.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text)|| string.IsNullOrWhiteSpace(txtSoyadi.Text))
            {
                MessageBox.Show("Müşteri Bilgisi Giriniz!");
                return;
            }
            Customer customer = new Customer();
            customer.Phone = txtTelefon.Text;
            customer.Name = txtAdi.Text;
            customer.Surname = txtSoyadi.Text;
            customer.Email = txtEmail.Text;
            customer.Address = txtAdres.Text;
            customer.IsActive = chbDurum.Checked;
            try
            {
                manager.Add(customer);
                Temizle();
                int sonuc = manager.SaveChanges(customer);
                if (sonuc > 0)
                {
                    dgvMusteriler.DataSource = manager.GetAll();
                    MessageBox.Show("Kayıt Başarılı!!");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu");
            }

        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value);
                var kayit = manager.Find(id);
                txtAdi.Text = kayit.Name;
                txtAdres.Text = kayit.Address;
                txtEmail.Text = kayit.Email;
                txtSoyadi.Text = kayit.Surname;
                txtTelefon.Text = kayit.Phone;
                chbDurum.Checked = kayit.IsActive;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text))
            {
                MessageBox.Show("Müşteri Bilgisi Giriniz!");
                return;
            }
            int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value);
            var kayit = manager.Find(id);
            Customer customer = manager.Find(id);
            customer.Phone = txtTelefon.Text;
            customer.Name = txtAdi.Text;
            customer.Surname = txtSoyadi.Text;
            customer.Email = txtEmail.Text;
            customer.Address = txtAdres.Text;
            customer.IsActive = chbDurum.Checked;
            try
            {
                manager.Update(customer);
                Temizle();
                int sonuc = manager.SaveChanges(customer);
                if (sonuc > 0)
                {
                    dgvMusteriler.DataSource = manager.GetAll();
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
            int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells[0].Value);
            Customer customer = manager.Find(id);
            try
            {
                manager.Delete(customer);
                int sonuc = manager.SaveChanges(customer);
                if (sonuc > 0)
                {
                    Temizle();
                    dgvMusteriler.DataSource = manager.GetAll();
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
            dgvMusteriler.DataSource = manager.GetAll(c => c.Name.Contains(txtAra.Text) || c.Phone.Contains(txtAra.Text) || c.Surname.Contains(txtAra.Text) || c.Email.Contains(txtAra.Text) || c.Address.Contains(txtAra.Text) );
            Temizle();
        }
    }
}
