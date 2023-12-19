using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFarmYS.PL
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuru_Click(object sender, EventArgs e)
        {
            FrmHayvan frmHayvan = new FrmHayvan();
            frmHayvan.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersoneel frmPersoneel = new FrmPersoneel();
            frmPersoneel.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();
        }
    }
}
