using MyFarmYS.BLL;
using MyFarmYS.MODEL.Entities;
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
    public partial class FrmPersoneel : Form
    {
        public FrmPersoneel()
        {
            InitializeComponent();
        }
        PersonelBusiness personelBusiness;
        Personel personel;
        DateTime Tarih;
        private void Form2_Load(object sender, EventArgs e)
        {
            Tarih = DateTime.Today;
            lblTarih.Text = Tarih.ToString();
            Listele();
        }

        private void Listele()
        {
            personelBusiness = new PersonelBusiness();
            var query = from x in personelBusiness.HepsiniGetir()
                        select new
                        {
                            ID = x.PersonelID,
                            AD = x.Ad,
                            SOYAD = x.Soyad,
                            CİNSİYET = x.Cinsiyet,
                            DOĞUM_TARİHİ = x.DogumTarih,
                            MEDENİ_DURUM = x.MedeniDurum,
                            FOTOĞFAR = x.Fotograf,
                            İŞE_GİRİŞ_TARİHİ = x.BaslamaTarih,
                            ÇALIŞMA_SÜRESİ = x.KıdemYili,
                            GÖREV = x.Gorev,
                            MAAŞ = x.Maas
                        };
            dataGridView1.DataSource = query.ToList();
        }
        private void Temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
                if (item is PictureBox)
                    pictureBox1.ImageLocation = string.Empty;
                if (item is DateTimePicker)
                    txtDogumTarih.Value = DateTime.Today;
                lblID.Text = string.Empty;
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
                if (item is DateTimePicker)
                    txtGirisTarih.Value = DateTime.Today;
                lblID.Text = string.Empty;

            }
        }


        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Empty;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            personelBusiness = new PersonelBusiness();
            personel = new Personel();

            try
            {
                personel.Ad = txtAd.Text;
                personel.Soyad = txtSoyad.Text;
                if (cbxCinsiyet.Text == "KADIN")
                    personel.Cinsiyet = "KADIN";
                if (cbxCinsiyet.Text == "ERKEK")
                    personel.Cinsiyet = "ERKEK";
                personel.DogumTarih = txtDogumTarih.Value;
                if (rdbBekar.Checked is true)
                    personel.MedeniDurum = false;
                if (rdbEvli.Checked is true)
                    personel.MedeniDurum = true;
                personel.Fotograf = pictureBox1.ImageLocation;
                personel.BaslamaTarih = txtGirisTarih.Value;
                personel.KıdemYili = Convert.ToDouble(txtCalismaSure.Text);
                personel.Gorev = txtGorev.Text;
                personel.Maas = Convert.ToDecimal(txtMaas.Text);
                personelBusiness.Ekle(personel);
                MessageBox.Show("Personel Eklendi");
                Listele();
                Temizle();

            }
            catch
            {
                if (rdbBekar.Checked is false && rdbEvli.Checked is false || txtCalismaSure.Text == null || txtMaas.Text == null)
                    MessageBox.Show("Zorunlu Alanları Giriniz!");

            }
        }

        private void txtGirisTarih_ValueChanged(object sender, EventArgs e)
        {
            // Çalışma süresini hesaplama
            TimeSpan sure = Convert.ToDateTime(lblTarih.Text) - Convert.ToDateTime(txtGirisTarih.Text);
            double yil = sure.TotalDays / 365;
            txtCalismaSure.Text = yil.ToString("#.0");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region datagridlere verilerin getirilmesi
            lblID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[1].Value == null)
            {
                txtAd.Text = string.Empty;
            }
            else txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[2].Value == null)
            {
                txtSoyad.Text = string.Empty;
            }
            else txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[3].Value == null)
            {
                cbxCinsiyet.Text = string.Empty;
            }
            else cbxCinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[4].Value == null)
            {
                txtDogumTarih.Text = DateTime.Today.ToString();
            }
            else txtDogumTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            if (dataGridView1.CurrentRow.Cells[5].Value is true)
            {
                rdbEvli.Checked = true;
            }
            else rdbBekar.Checked = true;

            if (dataGridView1.CurrentRow.Cells[6].Value == null)
            {
                pictureBox1.ImageLocation = string.Empty;
            }
            else pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[7].Value == null)
            {
                txtGirisTarih.Text = DateTime.Today.ToString();
            }
            else txtGirisTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());

            txtCalismaSure.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[9].Value == null)
            {
                txtGorev.Text = string.Empty;
            }
            else txtGorev.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            txtMaas.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            #endregion


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            personelBusiness = new PersonelBusiness();
            personel = new Personel();
            //int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                var sil = personelBusiness.HepsiniGetir().Where(w => w.PersonelID == id).FirstOrDefault();
                personelBusiness.Sil(sil);
                MessageBox.Show("Personel Silindi");
                Listele();
                Temizle();
            }
            catch
            {

                MessageBox.Show("Silmek istediğiniz kaydı seçiniz!");

            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            personelBusiness = new PersonelBusiness();
            personel = new Personel();

            try
            {
                personel.PersonelID = Convert.ToInt32(lblID.Text);
                personel.Ad = txtAd.Text;
                personel.Soyad = txtSoyad.Text;
                if (cbxCinsiyet.Text=="KADIN")
                    personel.Cinsiyet = "KADIN";
                if (cbxCinsiyet.Text == "ERKEK")
                    personel.Cinsiyet = "ERKEK";
                personel.DogumTarih = txtDogumTarih.Value;
                if (rdbBekar.Checked is true)
                    personel.MedeniDurum = false;
                if (rdbEvli.Checked is true)
                    personel.MedeniDurum = true;
                personel.Fotograf = pictureBox1.ImageLocation;
                personel.BaslamaTarih = txtGirisTarih.Value;
                personel.KıdemYili = Convert.ToDouble(txtCalismaSure.Text);
                personel.Gorev = txtGorev.Text;
                personel.Maas = Convert.ToDecimal(txtMaas.Text);
                personelBusiness.Guncelle(personel);
                MessageBox.Show("Personel Güncellendi");
                Listele();

            }
            catch
            {
                MessageBox.Show("Güncelleme için bir değişiklik yapılmadı!");

            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            txtAraSoyad.Text = null;
            if (txtAra.Text == null || txtAra.Text==string.Empty)
            {
                Listele();
            }
            else
            {
                int id = Convert.ToInt32(txtAra.Text);
                var query = personelBusiness.HepsiniGetir().Where(w => w.PersonelID == id);
                dataGridView1.DataSource = query.ToList();
            }

           
        }

        private void btnBulSoyad_Click(object sender, EventArgs e)
        {
            txtAra.Text = null;
            if (txtAraSoyad.Text == null || txtAraSoyad.Text == string.Empty)
            {
                Listele();
            }
            else
            {
                string soyad = txtAraSoyad.Text;
                var _query = personelBusiness.HepsiniGetir().Where(w => w.Soyad == soyad.ToUpper() || w.Soyad == soyad.ToLower());
                dataGridView1.DataSource = _query.ToList();
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Hide();
        }
    }



}
