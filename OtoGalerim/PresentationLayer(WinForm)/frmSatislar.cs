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
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();


        }
        frmAraclar frmAraclar = new frmAraclar();
        Satis satis = new Satis();
        Arac arac = new Arac();

        private void frmSatislar_Load(object sender, EventArgs e)
        {

            //Data_Binding(new Satis());

            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                cbxPersonel.DataSource = personelBLL.GetAll();
            }

            using (MusteriBLL musteriBLL=new MusteriBLL())
            {
                cbxMusteri.DataSource = musteriBLL.GetAll();
            }
 

        }
        void clearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }

        void Data_Binding(Satis _satis)
        {
            clearDataBinding();
            this.satis = _satis;
            txtSatisID.DataBindings.Add("Text", satis, "SatisID", true);
            // txtSatisAracID.DataBindings.Add("Text", satis, "AracId",true);
            cbxMusteri.DataBindings.Add("SelectedItem", satis, "MusteriAdSoyad", true);
            txtSatisTarih.DataBindings.Add("Text", satis, "SatisTarih", true);
            checkBoxKapora.DataBindings.Add("CheckState", satis, "Kapora", true);
            txtKaporaTarih.DataBindings.Add("Text", satis, "KaporaTarih", true);
            txtKaporaTutar.DataBindings.Add("Text", satis, "KaporaTutar", true);
            //txtSatisSatisTutari.DataBindings.Add("Text", satis, "SatisTutar", true);
            txtKalanTutar.DataBindings.Add("Text", satis, "KalanTutar", true);
            cbxOdemeTuru.DataBindings.Add("Text", satis, "OdemeTipi", true);
            cbxPersonel.DataBindings.Add("SelectedValue", satis, "PersonelId", true);

        }

        private void dataGridViewSatislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewSatislar.CurrentRow.Cells["SatisID"].Value);

            using (SatisBLL satisBLL = new SatisBLL())
            {
                Data_Binding(satisBLL.GetbyFilter(w => w.SatisID == id));
            }

            if (dataGridViewSatislar.CurrentRow.Cells["AracId"].Value == null) txtSatisAracID.Text = string.Empty;
            else txtSatisAracID.Text = dataGridViewSatislar.CurrentRow.Cells["AracId"].Value.ToString();

            if (dataGridViewSatislar.CurrentRow.Cells["SatisTutar"].Value == null) txtSatisSatisTutari.Text = string.Empty;
            else txtSatisSatisTutari.Text = dataGridViewSatislar.CurrentRow.Cells["SatisTutar"].Value.ToString();

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
            Data_Binding(new Satis());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SatisBLL satisBLL = new SatisBLL())
            {
                satis.AracId = Convert.ToInt32(txtSatisAracID.Text);
                satis.SatisTutar = Convert.ToDouble(txtSatisSatisTutari.Text);
                satisBLL.AddorUpdate(satis);
                satisBLL.Save();
                MessageBox.Show("Satış Başarılı");
                //todo frmAraclar da durum satıldı olarak değiştirilecek
            }
            this.Close();
            frmAraclar.Show();
           

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( dataGridViewSatislar.CurrentRow.Cells[0].Value);
            using (SatisBLL satisBLL=new SatisBLL())
            {
                satisBLL.Delete(w => w.SatisID == id);
                satisBLL.Save();
                MessageBox.Show("Kayıt Silindi");
                dataGridViewSatislar.DataSource = satisBLL.GetAll();
            }
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            using (SatisBLL satisBLL=new SatisBLL())
            {
                dataGridViewSatislar.DataSource = satisBLL.GetAll();
            }
        }

      
    }
}
