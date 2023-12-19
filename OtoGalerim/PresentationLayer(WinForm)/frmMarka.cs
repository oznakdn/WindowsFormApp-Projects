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

namespace PresentationLayer_WinForm_
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        Marka marka = new Marka();
        private void frmMarka_Load(object sender, EventArgs e)
        {

            using (MarkaBLL markaBLL = new MarkaBLL())
            {
                dataGridViewMarka.DataSource = markaBLL.GetAll();
            }
        }
        void clearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_Binding(Marka _marka)
        {
            clearDataBinding();
            this.marka = _marka;
            txtMarkaID.DataBindings.Add("Text", marka, "MarkaID", true);
            txtMarka.DataBindings.Add("Text", marka, "MarkaAd", true);
        }

        private void dataGridViewMarka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewMarka.CurrentRow.Cells["MarkaID"].Value);
            using (MarkaBLL markaBLL = new MarkaBLL())
            {
                Data_Binding(markaBLL.GetbyFilter(w => w.MarkaID == id));

            }
            if (dataGridViewMarka.CurrentRow.Cells["MarkaLogo"].Value == null) pictureBoxMarkaLogo.ImageLocation = string.Empty;
            else pictureBoxMarkaLogo.ImageLocation = dataGridViewMarka.CurrentRow.Cells["MarkaLogo"].Value.ToString();

        }

        private void btnFotoYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) pictureBoxMarkaLogo.ImageLocation = openFileDialog1.FileName;
        }

        private void btnFotoSil_Click(object sender, EventArgs e)
        {
            pictureBoxMarkaLogo.ImageLocation = string.Empty;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Marka());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (MarkaBLL markaBLL = new MarkaBLL())
            {
                marka.MarkaLogo = pictureBoxMarkaLogo.ImageLocation;
                markaBLL.AddorUpdate(marka);
                markaBLL.Save();
                MessageBox.Show("Kayıt Başarılı");
                dataGridViewMarka.DataSource = markaBLL.GetAll();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewMarka.CurrentRow.Cells["MarkaID"].Value);
            using (MarkaBLL markaBLL=new MarkaBLL())
            {
                markaBLL.Delete(w => w.MarkaID == id);
                markaBLL.Save();
                MessageBox.Show("Kayıt Silindi");
                dataGridViewMarka.DataSource = markaBLL.GetAll();

            }
        }
    }
}
