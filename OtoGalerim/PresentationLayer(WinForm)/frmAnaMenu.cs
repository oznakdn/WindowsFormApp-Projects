using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer_WinForm_
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAraclar frmAraclar = new frmAraclar();
            frmAraclar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSatislar frmSatislar = new frmSatislar();
            frmSatislar.Show();
            frmSatislar.btnSatislar.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMarka frmMarka = new frmMarka();
            frmMarka.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSeri frmSeri = new frmSeri();
            frmSeri.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmKullanici frmKullanici = new frmKullanici();
            frmKullanici.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPersonel frmPersonel = new frmPersonel();
            frmPersonel.Show();
        }
    }
}
