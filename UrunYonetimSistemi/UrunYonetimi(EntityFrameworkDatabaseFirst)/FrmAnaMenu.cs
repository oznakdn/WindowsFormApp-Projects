using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimi_EntityFrameworkDatabaseFirst_
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori form1 = new FrmKategori();
            form1.Show();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun();
            frmUrun.Show();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri();
            frmMusteri.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            FrmSatis frmSatis = new FrmSatis();
            frmSatis.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();
        }
    }
}
