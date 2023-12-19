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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'urunYonetimiDBDataSet.UrunlerTb' table. You can move, or remove it, as needed.
            this.urunlerTbTableAdapter.Fill(this.urunYonetimiDBDataSet.UrunlerTb);

        }
    }
}
