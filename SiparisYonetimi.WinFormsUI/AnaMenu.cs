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
            kullanıcı.ShowDialog();
        }

        private void markaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi marka = new MarkaYonetimi();
            marka.ShowDialog();
        }
    }
}
