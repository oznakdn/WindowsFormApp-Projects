using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntityLayer;

namespace PresentationLayer.WinForm
{
    public partial class frmBirim : Form
    {
        public frmBirim()
        {
            InitializeComponent();
        }
        Birim birim = new Birim();

        private void frmBirim_Load(object sender, EventArgs e)
        {
            Listele();
            Data_Binding(new Birim());
        }

        private void Listele()
        {
            using (BirimBLL birimBLL = new BirimBLL())
            {
                dataGridView1.DataSource = birimBLL.GetList();
            }
        }

        void clearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_Binding(Birim _birim)
        {
            this.birim = _birim;

            clearDataBinding();
            txtBirimId.DataBindings.Add("Text", birim, "BirimID");
            txtBirimAdi.DataBindings.Add("Text", birim, "BirimAdi");
            txtAciklama.DataBindings.Add("Text", birim, "Aciklama");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BirimID"].Value);
            using (BirimBLL birimBLL = new BirimBLL())
            {
                Data_Binding(birimBLL.GetByFilter(w => w.BirimID == id));
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Birim());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (BirimBLL birimBLL = new BirimBLL())
            {
                birimBLL.AddorUpdate(birim);
                birimBLL.Save();
                Listele();
                MessageBox.Show("Kayıt Başarılı");
            }
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BirimID"].Value);
            using (BirimBLL birimBLL = new BirimBLL())
            {
                birimBLL.Delete(w => w.BirimID == id);
                birimBLL.Save();
                Listele();
                MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPersonel frmPersonel = new frmPersonel();
            frmPersonel.Show();
        }
    }
}
