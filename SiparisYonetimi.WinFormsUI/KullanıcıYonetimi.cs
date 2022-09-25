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
    }
}
