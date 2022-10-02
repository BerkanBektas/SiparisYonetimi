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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıYonetimi kullanıcı = new KullanıcıYonetimi();
            this.Hide();
            kullanıcı.ShowDialog();
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi marka = new MarkaYonetimi();
            this.Hide();
            marka.ShowDialog();
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategori = new KategoriYonetimi();
            this.Hide();
            kategori.ShowDialog();
        }

        private void müşteriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriYonetimi müsteri = new MusteriYonetimi();
            this.Hide();
            müsteri.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            this.Hide();
            urunYonetimi.ShowDialog();
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Eğer ana ekran kapatılırsa uygulamayı kapat
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }
    }
}
