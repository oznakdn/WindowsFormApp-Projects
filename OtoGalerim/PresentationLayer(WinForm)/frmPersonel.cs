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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        Personel personel = new Personel();
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            Data_Binding(new Personel());

            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                dataGridViewPersoneller.DataSource = personelBLL.GetAll();
            }
        }

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                dataGridViewPersoneller.DataSource = personelBLL.GetAll(w => w.AdSoyad.Contains(txtPersonelAra.Text));
            }
        }

        private void btnFotoYukle_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPersonel.ImageLocation = openFileDialog1.FileName;
            }

        }

        private void btnFotoSil_Click(object sender, EventArgs e)
        {
            pictureBoxPersonel.ImageLocation = string.Empty;
        }
        void clearDataBindings()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_Binding(Personel _personel)
        {
            clearDataBindings();
            this.personel = _personel;
            txtPersonelID.DataBindings.Add("Text", personel, "PersonelID", true);
            txtAdSoyad.DataBindings.Add("Text", personel, "AdSoyad", true);
            txtGorev.DataBindings.Add("Text", personel, "Gorev", true);
            pictureBoxPersonel.DataBindings.Add("Text", personel, "Fotograf", true);
            cbxCinsiyet.DataBindings.Add("Text", personel, "Cinsiyet", true);
            // cbxMedeniDurum.DataBindings.Add("Text", personel, "MedeniDurum", true);
            txtGirisTarih.DataBindings.Add("Text", personel, "GirisTarih", true);
            txtCalismaYili.DataBindings.Add("Text", personel, "CalismaYili", true);
            txtMaas.DataBindings.Add("Text", personel, "Maas", true);
            txtDigerOdeme.DataBindings.Add("Text", personel, "DigerOdemeler", true);
            //txtToplamOdeme.DataBindings.Add("Text", personel, "ToplamOdeme", true);
        }

        private void dataGridViewPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewPersoneller.CurrentRow.Cells["PersonelID"].Value);
            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                Data_Binding(personelBLL.GetbyFilter(w => w.PersonelID == id));

            }
            //cbxMedeniDurum.SelectedText = dataGridViewPersoneller.CurrentRow.Cells["MedeniDurum"].Value.ToString();
            txtToplamOdeme.Text =Convert.ToDouble( dataGridViewPersoneller.CurrentRow.Cells["ToplamOdeme"].Value).ToString();

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Personel());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                if (cbxMedeniDurum.Text == "BEKAR") personel.MedeniDurum = false;
                if (cbxMedeniDurum.Text == "EVLİ") personel.MedeniDurum = true;
                personel.ToplamOdeme = Convert.ToDouble(txtMaas.Text) + Convert.ToDouble(txtDigerOdeme.Text);
                personelBLL.AddorUpdate(personel);
                personelBLL.Save();
                MessageBox.Show("Kayıt Başarılı");
                dataGridViewPersoneller.DataSource = personelBLL.GetAll();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewPersoneller.CurrentRow.Cells["PersonelID"].Value);
            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                personelBLL.Delete(w => w.PersonelID == id);
                personelBLL.Save();
                MessageBox.Show("Kayıt silindi");
                dataGridViewPersoneller.DataSource = personelBLL.GetAll();

            }
        }
    }
}
