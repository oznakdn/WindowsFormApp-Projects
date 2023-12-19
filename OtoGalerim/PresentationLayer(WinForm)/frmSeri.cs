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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }
        Seri Seri = new Seri();
        private void frmSeri_Load(object sender, EventArgs e)
        {
            
            using (SeriBLL seriBLL = new SeriBLL())
            {
                dataGridViewSeri.DataSource = seriBLL.GetAll();
            }

            using (MarkaBLL markaBLL = new MarkaBLL())
            {
                cbxMarka.DataSource = markaBLL.GetAll();
            }

            Data_Binding(new Seri());
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Seri());
        }
        void clearData_Binding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_Binding(Seri _seri)
        {
            clearData_Binding();
            this.Seri = _seri;
            txtSeriID.DataBindings.Add("Text", Seri, "SeriID", true);
            txtSeri.DataBindings.Add("Text", Seri, "SeriAd", true);

        }
        private void dataGridViewSeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewSeri.CurrentRow.Cells["SeriID"].Value);
            using (SeriBLL seriBLL = new SeriBLL())
            {
                Data_Binding(seriBLL.GetbyFilter(w => w.SeriID == id));
            }
            if (dataGridViewSeri.CurrentRow.Cells["MarkaId"].Value == null) cbxMarka.SelectedValue = null;
            else cbxMarka.SelectedValue = dataGridViewSeri.CurrentRow.Cells["MarkaId"].Value.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SeriBLL seriBLL = new SeriBLL())
            {
                Seri.MarkaId = (int)cbxMarka.SelectedValue;
                seriBLL.AddorUpdate(Seri);
                seriBLL.Save();
                dataGridViewSeri.DataSource = seriBLL.GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewSeri.CurrentRow.Cells["SeriID"].Value);
            using (SeriBLL seriBLL=new SeriBLL())
            {
                seriBLL.Delete(w => w.SeriID == id);
                seriBLL.Save();
                dataGridViewSeri.DataSource = seriBLL.GetAll();
                MessageBox.Show("Kayıt silindi");
            }
        }
    }
}
