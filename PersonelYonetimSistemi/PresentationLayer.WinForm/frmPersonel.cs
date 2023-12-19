using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;


namespace PresentationLayer.WinForm
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        Personel personel = new Personel();
        public void Listele()
        {
            using (PersonelBLL personelBLL=new PersonelBLL())
            {
                dataGridView1.DataSource = personelBLL.GetList();

            }
        }
        public void BirimComboboxListele()
        {
            using (BirimBLL birimBLL = new BirimBLL())
            {
                cbxBirim.DataSource = birimBLL.GetList();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Listele();
            // Birimlerin cbxBirim combobox da listelenmesi
            BirimComboboxListele();

            Data_Binding(new Personel());

        }



        // Form içindeki bütün DataBinding'leri temizlemek için
        void ClearDataBiding()
        {
            foreach (Control item in Controls)
            {
                item.DataBindings.Clear();
            }
        }

        void Data_Binding(Personel personel1) //DataBinding metodu
        {
            ClearDataBiding(); //ClearDataBindingClear metodunu çağırıyoruz.
            this.personel = personel1;
            txtPersonelID.DataBindings.Add("Text", personel, "PersonelID");
            txtAdSoyad.DataBindings.Add("Text", personel, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", personel, "Telefon");
            txtAdres.DataBindings.Add("Text", personel, "Adres");
            txtEmail.DataBindings.Add("Text", personel, "Email");
            txtTarih.DataBindings.Add("Text", personel, "Tarih",true);
            checkBoxAktif.DataBindings.Add("CheckState", personel, "AktifMi", true);
            cbxBirim.DataBindings.Add("SelectedValue", personel, "BirimID", true);
            
        }
        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {

            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                dataGridView1.DataSource = personelBLL.GetList(w => w.AdSoyad.Contains(txtPersonelAra.Text));
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (PersonelBLL personelBLL =new PersonelBLL())
            {
                personelBLL.AddorUpdate(personel);
                personelBLL.Save();
                Listele();
            }  
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            using (PersonelBLL personelBLL=new PersonelBLL())
            {
                Data_Binding(personelBLL.GetByFilter(w => w.PersonelID == id));

            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Personel());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (PersonelBLL personelBLL = new PersonelBLL())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonelID"].Value);
                personelBLL.Delete(w => w.PersonelID == id);
                personelBLL.Save();
                Listele();
                Data_Binding(new Personel());
            }
        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            frmBirim frmBirim = new frmBirim();
            this.Hide();
            frmBirim.Show();
        }
    }
}
