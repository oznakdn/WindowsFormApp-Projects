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
    public partial class FrmHayvan : Form
    {
        public FrmHayvan()
        {
            InitializeComponent();
        }

        PersonelBusiness personelBusiness;
        HayvanBusiness hayvanBusiness;
        LaktasyonBusiness laktasyonBusiness;
        DogumBusiness dogumBusiness;
        UremeBusiness uremeBusiness;
        SaglikBusiness saglikBusiness;
        AsilamaBusiness asilamaBusiness;
        Hayvan hayvan;
        Ureme ureme;
        Laktasyon laktasyon;
        Dogum dogum;
        Saglik saglik;
        Asilama asilama;

        DateTime Tarih;
        private void Temizle()
        {
            lblIDHayvan.Text = string.Empty;
            lblVerimGrup.Text = string.Empty;
            txtIDHayvan.Text = string.Empty;
            txtCanliAgirlik.Text = string.Empty;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
                txtDogumTarih.Value = DateTime.Today;
                pictureBox1.ImageLocation = string.Empty;
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                    item.Text = null;
                txtDamzKullTarih.Value = DateTime.Today;
            }
        }
        private void HayvanlariListele()
        {
            var query = from x in hayvanBusiness.HepsiniGetir()
                        select new
                        {
                            ID = x.HayvanID,
                            x.Ad,
                            x.KupeNo,
                            x.Fotograf,
                            x.Grup,
                            x.Cinsiyet,
                            x.DogumTarih,
                            x.Yas,
                            x.DogumAgirlik,
                            x.DogumTipi,
                            x.DogumSekli,
                            x.CanliAgirlik,
                            x.LaktSayisi,
                            x.OrtLakSuresi,
                            x.OrtGunSutVerimi,
                            x.OrtLaktSutVerimi,
                            x.VerimGrup,
                            x.DamizliktaKullTarih,
                            x.DamizlikYasi,
                            x.DamizlikAgirlik,
                            Toplam_Yavru = x.TopYavruSayisi,
                            x.UremePerformansi,
                        };

            dataGridViewGenel.DataSource = query.ToList();
        }
        private void LaktasyonListele()
        {
            var lakListe = from y in laktasyonBusiness.HepsiniGetir()
                           select new
                           {
                               y.ID,
                               y.Durum,
                               Kaçıncı_Lak = y.LaktSira,
                               Başlangıç = y.LaktBasTarih,
                               Bitiş = y.LaktBitTarih,
                               Laktasyon_Süresi = y.LaktSuresi,
                               y.GunOrtSutVer,
                               y.LakSutVer,
                               y.SutYagOran,
                               y.HayvanID
                           };
            dataGridViewLaktasyon.DataSource = lakListe.ToList();
        }
        private void LaktasyonTemizle()
        {

            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;


            }
        }
        private void UremeListele()
        {
            dataGridViewUreme.DataSource = uremeBusiness.HepsiniGetir();
        }
        private void TemizleUreme()
        {
            foreach (Control item in groupBox7.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;

            }
        }
        private void DogumListele()
        {
            dataGridViewDogum.DataSource = dogumBusiness.HepsiniGetir();
        }
        private void DogumTemizle()
        {
            foreach (Control item in groupBox8.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
            }
        }
        private void SaglikListele()
        {
            dataGridViewSaglik.DataSource = saglikBusiness.HepsiniGetir();
        }
        private void SaglikTemizle()
        {
            foreach (Control item in groupBox9.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
            }
        }
        private void AsilamaListele()
        {
            dataGridViewAsilama.DataSource = asilamaBusiness.HepsiniGetir();
        }
        private void AsilamaTemizle()
        {
            foreach (Control item in groupBox10.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
            }
        }


        private void FrmHayvan_Load(object sender, EventArgs e)
        {
            //Form Açıldığında tarihin formda görünmesi
            Tarih = DateTime.Today;
            lblTarih.Text = Tarih.ToString();


            hayvanBusiness = new HayvanBusiness();
            laktasyonBusiness = new LaktasyonBusiness();
            uremeBusiness = new UremeBusiness();
            personelBusiness = new PersonelBusiness();
            dogumBusiness = new DogumBusiness();
            saglikBusiness = new SaglikBusiness();
            asilamaBusiness = new AsilamaBusiness();

            HayvanlariListele();
            LaktasyonListele();
            UremeListele();
            DogumListele();
            SaglikListele();
            AsilamaListele();

            // personellerin tabUreme de listelenmesi
            cbxPersonel.DataSource = personelBusiness.HepsiniGetir();
            cbxPersonel.DisplayMember = "Ad";
            cbxPersonel.ValueMember = "PersonelID";


            // personellerin tabSaglik da listelenmesi
            var queryPersonel = from p in personelBusiness.HepsiniGetir() select p.PersonelID;
            cbxSaglikPersonel.DataSource = queryPersonel.ToList();

            // personellerin tabAsilama da listelenmesi
            cbxAsiPersonel.DataSource = personelBusiness.HepsiniGetir().ToList();
            cbxAsiPersonel.ValueMember = "PersonelID";
            cbxAsiPersonel.DisplayMember = "Ad";


        }



        #region Resim Ekleme Butonu
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        #endregion

        #region Resim Sil Butonu
        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Empty;
        }

        #endregion
        #region Hayvan-Ekle Butonu
        private void btnEkleHayvan_Click(object sender, EventArgs e)
        {
            hayvanBusiness = new HayvanBusiness();
            hayvan = new Hayvan();

           
            try
            {
                hayvan.Ad = txtAd.Text;
                hayvan.KupeNo = txtKupeNo.Text;
                hayvan.Fotograf = pictureBox1.ImageLocation;
                hayvan.Grup = txtGrup.Text;
                hayvan.Cinsiyet = cbxCinsiyet.Text;
                hayvan.DogumTarih = txtDogumTarih.Value;
                hayvan.Yas = Convert.ToInt16(txtYas.Text);
                hayvan.DogumAgirlik = Convert.ToInt16(txtDogumAgirlik.Text);
                hayvan.DogumTipi = cbxDogumTipi.Text;
                hayvan.DogumSekli = cbxDogumSekli.Text;
                hayvan.CanliAgirlik = Convert.ToInt16(txtCanliAgirlik.Text);
                hayvan.LaktSayisi = Convert.ToInt16(txtLakSayi.Text);
                hayvan.OrtLakSuresi = Convert.ToInt16(txtOrtLakSuresi.Text);
                hayvan.OrtGunSutVerimi = Convert.ToInt16(txtOrtGunSutVer.Text);
                hayvan.OrtLaktSutVerimi = Convert.ToInt16(txtOrtLakSutVer.Text);
                hayvan.VerimGrup = lblVerimGrup.Text;
                hayvan.DamizliktaKullTarih = txtDamzKullTarih.Value;
                hayvan.DamizlikYasi = Convert.ToInt16(txtDamizlikYas.Text);
                hayvan.DamizlikAgirlik = Convert.ToInt16(txtDamizlikAgirlik.Text);
                hayvan.TopYavruSayisi = Convert.ToInt16(txtToplamYavru.Text);
                hayvan.UremePerformansi = Convert.ToInt16(txtUremePerformans.Text);
                hayvanBusiness.Ekle(hayvan);
                MessageBox.Show($"{hayvan.KupeNo} Kupe Numaralı hayvan kayıt edildi");
                HayvanlariListele();
                Temizle();

            }
            catch
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!");

            }

        }

        #endregion

        #region Yaşın ay olarak hesaplanması ve grupların belirlenmesi
        private void txtDogumTarih_ValueChanged(object sender, EventArgs e)
        {
            // Yaşın ay bazında hesaplanması
            TimeSpan tarihFarki = Convert.ToDateTime(lblTarih.Text) - Convert.ToDateTime(txtDogumTarih.Text);
            double ay = tarihFarki.TotalDays / 30;
            if (ay < 1)
            {
                txtYas.Text = 0.ToString();
            }
            else
            {
                txtYas.Text = ay.ToString("#.");

            }

            // Grubun belirlenmesi

            if (Convert.ToInt16(txtYas.Text) <= 6)
            {
                txtGrup.Text = "BUZAĞI";
            }
            else if (Convert.ToInt16(txtYas.Text) > 6 && Convert.ToInt16(txtYas.Text) < 12)
            {
                txtGrup.Text = "DANA";
            }
            else if (cbxCinsiyet.Text == "DİŞİ" && Convert.ToInt16(txtYas.Text) >= 12 && Convert.ToInt16(txtYas.Text) < 30)
            {
                txtGrup.Text = "DÜVE";
            }
            else if (cbxCinsiyet.Text == "ERKEK" && Convert.ToInt16(txtYas.Text) >= 12 && Convert.ToInt16(txtYas.Text) < 24)
            {
                txtGrup.Text = "TOSUN";
            }
            else if (cbxCinsiyet.Text == "ERKEK" && Convert.ToInt16(txtYas.Text) >= 24)
            {
                txtGrup.Text = "BOĞA";
            }
            else if (cbxCinsiyet.Text == "DİŞİ" && Convert.ToInt16(txtYas.Text) > 30)
            {
                txtGrup.Text = "İNEK";
            }
        }

        #endregion

        #region Hayvan-Güncelle Butonu
        private void btnGuncelleHayvan_Click(object sender, EventArgs e)
        {
            hayvanBusiness = new HayvanBusiness();
            hayvan = new Hayvan();

            try
            {
                hayvan.HayvanID = Convert.ToInt32(lblIDHayvan.Text);
                hayvan.Ad = txtAd.Text;
                hayvan.KupeNo = txtKupeNo.Text;
                hayvan.Fotograf = pictureBox1.ImageLocation;
                hayvan.Grup = txtGrup.Text;
                hayvan.Cinsiyet = cbxCinsiyet.Text;
                hayvan.DogumTarih = txtDogumTarih.Value;
                hayvan.Yas = Convert.ToInt16(txtYas.Text);
                hayvan.DogumAgirlik = Convert.ToInt16(txtDogumAgirlik.Text);
                hayvan.DogumTipi = cbxDogumTipi.Text;
                hayvan.DogumSekli = cbxDogumSekli.Text;
                hayvan.CanliAgirlik = Convert.ToInt16(txtCanliAgirlik.Text);
                hayvan.LaktSayisi = Convert.ToInt16(txtLakSayi.Text);
                hayvan.OrtLakSuresi = Convert.ToInt16(txtOrtLakSuresi.Text);
                hayvan.OrtGunSutVerimi = Convert.ToInt16(txtOrtGunSutVer.Text);
                hayvan.OrtLaktSutVerimi = Convert.ToInt16(txtOrtLakSutVer.Text);
                hayvan.VerimGrup = lblVerimGrup.Text;
                hayvan.DamizliktaKullTarih = txtDamzKullTarih.Value;
                hayvan.DamizlikYasi = Convert.ToInt16(txtDamizlikYas.Text);
                hayvan.DamizlikAgirlik = Convert.ToInt16(txtDamizlikAgirlik.Text);
                hayvan.TopYavruSayisi = Convert.ToInt16(txtToplamYavru.Text);
                hayvan.UremePerformansi = Convert.ToInt16(txtUremePerformans.Text);
                hayvanBusiness.Guncelle(hayvan);
                MessageBox.Show($"{hayvan.HayvanID} nolu hayvan güncellendi");
                HayvanlariListele();
                Temizle();

            }
            catch
            {
                MessageBox.Show("Güncellenecek veri bulunamadı!");

            }
        }

        #endregion

        #region datagridViewGenel cellclic olayında alanların textboxlara aktarılması
        private void dataGridViewGenel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lblIDHayvan.Text = dataGridViewGenel.CurrentRow.Cells[0].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[1].Value == null) txtAd.Text = string.Empty;
            else txtAd.Text = dataGridViewGenel.CurrentRow.Cells[1].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[2].Value == null) txtKupeNo.Text = string.Empty;
            else txtKupeNo.Text = dataGridViewGenel.CurrentRow.Cells[2].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[3].Value == null) pictureBox1.ImageLocation = string.Empty;
            else pictureBox1.ImageLocation = dataGridViewGenel.CurrentRow.Cells[3].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[4].Value == null) txtGrup.Text = string.Empty;
            else txtGrup.Text = dataGridViewGenel.CurrentRow.Cells[4].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[5].Value == null) cbxCinsiyet.Text = string.Empty;
            else cbxCinsiyet.Text = dataGridViewGenel.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[6].Value == null) txtDogumTarih.Value = DateTime.Today;
            else txtDogumTarih.Value = Convert.ToDateTime(dataGridViewGenel.CurrentRow.Cells[6].Value);

            if (dataGridViewGenel.CurrentRow.Cells[7].Value == null) txtYas.Text = string.Empty;
            else txtYas.Text = dataGridViewGenel.CurrentRow.Cells[7].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[8].Value == null) txtDogumAgirlik.Text = string.Empty;
            else txtDogumAgirlik.Text = dataGridViewGenel.CurrentRow.Cells[8].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[9].Value == null) cbxDogumTipi.Text = string.Empty;
            else cbxDogumTipi.Text = dataGridViewGenel.CurrentRow.Cells[9].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[10].Value == null) cbxDogumSekli.Text = string.Empty;
            else cbxDogumSekli.Text = dataGridViewGenel.CurrentRow.Cells[10].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[11].Value == null) txtCanliAgirlik.Text = string.Empty;
            else txtCanliAgirlik.Text = dataGridViewGenel.CurrentRow.Cells[11].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[12].Value == null) txtLakSayi.Text = string.Empty;
            else txtLakSayi.Text = dataGridViewGenel.CurrentRow.Cells[12].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[13].Value == null) txtOrtLakSuresi.Text = string.Empty;
            else txtOrtLakSuresi.Text = dataGridViewGenel.CurrentRow.Cells[13].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[14].Value == null) txtOrtLakSuresi.Text = string.Empty;
            else txtOrtGunSutVer.Text = dataGridViewGenel.CurrentRow.Cells[14].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[15].Value == null) txtOrtLakSutVer.Text = string.Empty;
            else txtOrtLakSutVer.Text = dataGridViewGenel.CurrentRow.Cells[15].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[16].Value == null) lblVerimGrup.Text = string.Empty;
            else lblVerimGrup.Text = dataGridViewGenel.CurrentRow.Cells[16].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[17].Value == null) txtDamzKullTarih.Value = DateTime.Today;
            else txtDamzKullTarih.Value = Convert.ToDateTime(dataGridViewGenel.CurrentRow.Cells[17].Value);

            if (dataGridViewGenel.CurrentRow.Cells[18].Value == null) txtDamizlikYas.Text = string.Empty;
            else txtDamizlikYas.Text = dataGridViewGenel.CurrentRow.Cells[18].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[19].Value == null) txtDamizlikAgirlik.Text = string.Empty;
            else txtDamizlikAgirlik.Text = dataGridViewGenel.CurrentRow.Cells[19].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[20].Value == null) txtToplamYavru.Text = string.Empty;
            else txtToplamYavru.Text = dataGridViewGenel.CurrentRow.Cells[20].Value.ToString();

            if (dataGridViewGenel.CurrentRow.Cells[21].Value == null) txtUremePerformans.Text = string.Empty;
            else txtUremePerformans.Text = dataGridViewGenel.CurrentRow.Cells[21].Value.ToString();


            #region DatagridviewGenel de kayıt seçildğinde ilgili hayvana ait laktasyon bilgilerinin datagridviewLaktasyon da listelenmesi
            txtIDHayvan.Text = lblIDHayvan.Text;
            if (dataGridViewLaktasyon.Rows.Count < 1)
            {
                LaktasyonListele();
            }
            else
            {
                int idHayvan = Convert.ToInt32(txtIDHayvan.Text);
                var hayvanGetir = laktasyonBusiness.HepsiniGetir().Where(w => w.HayvanID == idHayvan).ToList();
                dataGridViewLaktasyon.DataSource = hayvanGetir;
            }

            #endregion

            dataGridViewLaktasyon.Columns[10].Visible = false;

            #region DatagridviewGenel de kayıt seçildiğinde ilgili hayvana ait üreme bilgilerinin datagridviewUreme de listelenmesi
            txtHayvanIdUreme.Text = lblIDHayvan.Text;


            if (dataGridViewUreme.Rows.Count < 1)
            {
                UremeListele();
            }
            else
            {
                int id = Convert.ToInt32(txtHayvanIdUreme.Text);
                var sorgu = uremeBusiness.HepsiniGetir().Where(w => w.HayvanID == id).ToList();
                dataGridViewUreme.DataSource = sorgu;
            }
            dataGridViewUreme.Columns[12].Visible = false;

            #endregion

            #region DatagridViewGenel de kayıt sçildiğinde ilgili hayvana ait doğum bilgilerinin datagridviewDogum da listelenmesi

            txtDogumHayvanID.Text = lblIDHayvan.Text;
            if (dataGridViewDogum.Rows.Count < 1)
            {
                DogumListele();
            }
            else
            {
                int hayvanIDUreme = Convert.ToInt32(txtDogumHayvanID.Text);
                var queryDogum = dogumBusiness.HepsiniGetir().Where(w => w.HayvanID == hayvanIDUreme).ToList();
                dataGridViewDogum.DataSource = queryDogum;
            }

            dataGridViewDogum.Columns[11].Visible = false;
            #endregion

            #region DatagridGenel'de kayıt seçildiğinde hayvana ait sağlık bilgilerinin datagridviewSaglik da listelenmesi
            txtSaglikHayvanID.Text = lblIDHayvan.Text;
            if (dataGridViewSaglik.Rows.Count < 1)
            {
                SaglikListele();
            }
            else
            {
                int _id = Convert.ToInt32(txtSaglikHayvanID.Text);
                var saglikQuery = saglikBusiness.HepsiniGetir().Where(w => w.HayvanID == _id);
                dataGridViewSaglik.DataSource = saglikQuery.ToList();
            }
            dataGridViewSaglik.Columns[9].Visible = false;

            #endregion

            #region DatagridviewGenel de kayıt seçildiğinde hayvana ait aşı bilgilerinin datagridviewAsilama da listelenmesi
            txtAsiHayvanID.Text = lblIDHayvan.Text;
            if (dataGridViewAsilama.Rows.Count > 1)
            {
                int idHayvan = Convert.ToInt32(txtAsiHayvanID.Text);
                var queryAsi = asilamaBusiness.HepsiniGetir().Where(w => w.HayvanID == idHayvan).ToList();
                dataGridViewAsilama.DataSource = queryAsi;
            }
            else
            {
                AsilamaListele();
            }
            dataGridViewAsilama.Columns[8].Visible = false;
            #endregion
        }

        #endregion
        #region Hayvan-Temizle Butonu
        private void btnTemizleHayvan_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        #endregion

        #region Hayvan-Sil Butonu
        private void btnSilHayvan_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblIDHayvan.Text);
                var sil = hayvanBusiness.HepsiniGetir().Where(w => w.HayvanID == id).FirstOrDefault();
                hayvanBusiness.Sil(sil);
                MessageBox.Show($"{id} nolu hayvan silindi");
                HayvanlariListele();
            }
            catch
            {

                MessageBox.Show("Silmek istediğiniz kaydı seçiniz!");
            }

        }

        #endregion
        #region Hayvan-YeniKayıt Butonu
        private void btnYeniKayitHayvan_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        #endregion
        #region Laktasyon Ekle
        private void btnEkleLakt_Click(object sender, EventArgs e)
        {
            try
            {
                laktasyon = new Laktasyon();
                if (rdbLaktasyonda.Checked is true)
                    laktasyon.Durum = true;
                if (rdbKuruda.Checked is true)
                    laktasyon.Durum = false;
                laktasyon.LaktSira = Convert.ToInt16(txtKacinciLaktasyon.Text);
                laktasyon.LaktBasTarih = txtLakBasTarih.Value;
                laktasyon.LaktBitTarih = txtLakBitTarih.Value;
                laktasyon.LaktSuresi = Convert.ToInt16(txtLakSuresi.Text);
                laktasyon.GunOrtSutVer = Convert.ToInt16(txtGunOrtSut.Text);
                laktasyon.LakSutVer = Convert.ToInt16(txtLakSut.Text);
                laktasyon.HayvanID = Convert.ToInt32(txtIDHayvan.Text);
                laktasyon.SutYagOran = Convert.ToDouble(txtSutYagOrani.Text);
                laktasyonBusiness.Ekle(laktasyon);
                MessageBox.Show($"{laktasyon.HayvanID} ID nolu hayvana ait kayıt girildi");
                LaktasyonListele();
            }
            catch
            {

                MessageBox.Show("Zorunlu alanları giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        #endregion

        #region Laktasyon Süresini hesaplama
        private void txtLakBasTarih_ValueChanged(object sender, EventArgs e)
        {
            // Laktasyon süresini hesaplama
            TimeSpan fark = Convert.ToDateTime(txtLakBitTarih.Value) - Convert.ToDateTime(txtLakBasTarih.Value);
            short gun = (short)fark.TotalDays;
            txtLakSuresi.Text = gun.ToString();
        }
        #endregion

        #region txtHayvanID silindiğinde bütün hayvanlara ait laktasyonların listelenmesi
        private void txtIDHayvan_TextChanged(object sender, EventArgs e)
        {

            if (txtIDHayvan.Text == string.Empty)
            {
                LaktasyonListele();
            }
        }

        #endregion

        #region DatagridviewLaktasyon'daki laktasyon süt verim ortalamsını hesaplama
        private void btnLakVerimOrtHesapla_Click(object sender, EventArgs e)
        {
            int toplamLakSut = 0;
            for (int i = 0; i < dataGridViewLaktasyon.Rows.Count; i++)
            {
                toplamLakSut += Convert.ToInt32(dataGridViewLaktasyon.Rows[i].Cells[7].Value);
                double ortLakSut = toplamLakSut / Convert.ToInt32(dataGridViewLaktasyon.Rows.Count);
                txtortsut.Text = ortLakSut.ToString();
                txtOrtLakSutVer.Text = ortLakSut.ToString();
            }
        }

        #endregion
        #region DatagridviewLaktasyon'daki günlük süt verim ortalamasını hesaplama
        private void btnGunVerimOrtHesapla_Click(object sender, EventArgs e)
        {
            int toplamGunSut = 0;
            for (int i = 0; i < dataGridViewLaktasyon.Rows.Count; i++)
            {
                toplamGunSut += Convert.ToInt32(dataGridViewLaktasyon.Rows[i].Cells[6].Value);
                double ortGunSut = toplamGunSut / Convert.ToInt32(dataGridViewLaktasyon.Rows.Count);
                txtGunSut.Text = ortGunSut.ToString();
                txtOrtGunSutVer.Text = ortGunSut.ToString();

            }
        }

        #endregion
        #region DatagridViewLaktastyon'daki laktasyon suresi ortalamasını hesaplama
        private void button1_Click(object sender, EventArgs e)
        {
            int toplamLakSuresi = 0;
            for (int i = 0; i < dataGridViewLaktasyon.Rows.Count; i++)
            {
                toplamLakSuresi += Convert.ToInt32(dataGridViewLaktasyon.Rows[i].Cells[5].Value);
                double laktSureOrt = toplamLakSuresi / Convert.ToInt32(dataGridViewLaktasyon.Rows.Count);
                txtLaktSurelerOrt.Text = laktSureOrt.ToString();
                txtOrtLakSuresi.Text = laktSureOrt.ToString();

            }
        }

        #endregion

        #region Laktasyon süt verimini hesaplama ve datagriddeki kayıtlardan ortalamasını hesaplama
        private void btnlakSutHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                short laksure = Convert.ToInt16(txtLakSuresi.Text);
                short gunsut = Convert.ToInt16(txtGunOrtSut.Text);
                int laksut = (short)(laksure * gunsut);
                txtLakSut.Text = laksut.ToString();
            }
            catch
            {

                MessageBox.Show("Gerekli alanları giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region datagridViewLaktasyon cellclic olayında alanların textboxlara getirilmesi
        private void dataGridViewLaktasyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLaktasyon.CurrentRow.Cells[0].Value == null) lblLaktID.Text = string.Empty;
            else lblLaktID.Text = dataGridViewLaktasyon.CurrentRow.Cells[0].Value.ToString();


            if (dataGridViewLaktasyon.CurrentRow.Cells[1].Value == null)
            {
                rdbLaktasyonda.Checked = false;
                rdbKuruda.Checked = false;
            }
            else
            {
                if (dataGridViewLaktasyon.CurrentRow.Cells[1].Value is true)
                    rdbLaktasyonda.Checked = true;
                if (dataGridViewLaktasyon.CurrentRow.Cells[1].Value is false)
                    rdbKuruda.Checked = true;
            }

            if (dataGridViewLaktasyon.CurrentRow.Cells[2].Value == null) txtKacinciLaktasyon.Text = string.Empty;
            else txtKacinciLaktasyon.Text = dataGridViewLaktasyon.CurrentRow.Cells[2].Value.ToString();

            if (dataGridViewLaktasyon.CurrentRow.Cells[3].Value == null) txtLakBasTarih.Value = DateTime.Today;
            else txtLakBasTarih.Value = Convert.ToDateTime(dataGridViewLaktasyon.CurrentRow.Cells[3].Value);

            if (dataGridViewLaktasyon.CurrentRow.Cells[4].Value == null) txtLakBitTarih.Value = DateTime.Today;
            else txtLakBitTarih.Value = Convert.ToDateTime(dataGridViewLaktasyon.CurrentRow.Cells[4].Value);


            if (dataGridViewLaktasyon.CurrentRow.Cells[5].Value == null) txtLakSuresi.Text = string.Empty;
            else txtLakSuresi.Text = dataGridViewLaktasyon.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewLaktasyon.CurrentRow.Cells[6].Value == null) txtGunOrtSut.Text = string.Empty;
            else txtGunOrtSut.Text = dataGridViewLaktasyon.CurrentRow.Cells[6].Value.ToString();

            if (dataGridViewLaktasyon.CurrentRow.Cells[7].Value == null) txtLakSut.Text = string.Empty;
            else txtLakSut.Text = dataGridViewLaktasyon.CurrentRow.Cells[7].Value.ToString();

            if (dataGridViewLaktasyon.CurrentRow.Cells[8].Value == null) txtSutYagOrani.Text = string.Empty;
            else txtSutYagOrani.Text = dataGridViewLaktasyon.CurrentRow.Cells[8].Value.ToString();

            if (dataGridViewLaktasyon.CurrentRow.Cells[9].Value == null) txtIDHayvan.Text = string.Empty;
            else txtIDHayvan.Text = dataGridViewLaktasyon.CurrentRow.Cells[9].Value.ToString();


        }


        #endregion

        #region Laktasyon Temizle butonu
        private void btnTemizleLakt_Click(object sender, EventArgs e)
        {
            LaktasyonTemizle();
        }

        #endregion

        #region Laktasyon Yeni kayıt butonu
        private void btnYeniKayitLakt_Click(object sender, EventArgs e)
        {
            LaktasyonTemizle();
        }

        #endregion
        #region cbxCinsiyet=="Erkek" ise tabLaktasyon'daki alanların pasif gelmesi, cbxCinsiyet=="DİŞİ" ise aktif gelmesi
        private void cbxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxCinsiyet.Text == "ERKEK")
            {



                dataGridViewLaktasyon.Visible = false;
                btnEkleLakt.Enabled = false;
                btnGuncelleLakt.Enabled = false;
                btnSilLakt.Enabled = false;
                btnTemizleLakt.Enabled = false;
                btnYeniKayitLakt.Enabled = false;

                dataGridViewDogum.Visible = false;
                btnEkleDogum.Enabled = false;
                btnGuncelleDogum.Enabled = false;
                btnSilDogum.Enabled = false;
                btnYeniKayitDogum.Enabled = false;
                btnTemizleDogum.Enabled = false;
                btnlakSutHesapla.Enabled = false;

                dataGridViewUreme.Visible = false;
                btnEkleUreme.Enabled = false;
                btnGuncelleUreme.Enabled = false;
                btnSilUreme.Enabled = false;
                btnYeniKayitUreme.Enabled = false;
                btnTemizleUreme.Enabled = false;
                btnKuruSuresiHesapla.Enabled = false;

           


                foreach (Control item in groupBox4.Controls)
                {
                    if (item is TextBox)
                        item.Enabled = false;
                    if (item is Button)
                        item.Enabled = false;
                    if (item is DateTimePicker)
                        item.Enabled = false;
                    if (item is RadioButton)
                        item.Enabled = false;
                }
                foreach (Control item in groupBox5.Controls)
                {
                    if (item is TextBox)
                        item.Enabled = false;
                    if (item is Button)
                        item.Enabled = false;
                }

            }
            else
            {

                dataGridViewLaktasyon.Visible = true;
                btnEkleLakt.Enabled = true;
                btnGuncelleLakt.Enabled = true;
                btnSilLakt.Enabled = true;
                btnTemizleLakt.Enabled = true;
                btnYeniKayitLakt.Enabled = true;

                dataGridViewDogum.Visible = true;
                btnEkleDogum.Enabled = true;
                btnGuncelleDogum.Enabled = true;
                btnSilDogum.Enabled = true;
                btnYeniKayitDogum.Enabled = true;
                btnTemizleDogum.Enabled = true;
                btnlakSutHesapla.Enabled = true;

                dataGridViewUreme.Visible = true;
                btnEkleUreme.Enabled = true;
                btnGuncelleUreme.Enabled = true;
                btnSilUreme.Enabled = true;
                btnYeniKayitUreme.Enabled = true;
                btnTemizleUreme.Enabled = true;
                btnKuruSuresiHesapla.Enabled = true;

                foreach (Control item in groupBox4.Controls)
                {
                    if (item is TextBox)
                        item.Enabled = true;
                    if (item is Button)
                        item.Enabled = true;
                    if (item is DateTimePicker)
                        item.Enabled = true;
                    if (item is RadioButton)
                        item.Enabled = true;
                }
                foreach (Control item in groupBox5.Controls)
                {
                    if (item is TextBox)
                        item.Enabled = true;
                    if (item is Button)
                        item.Enabled = true;
                }

            }
        }

        #endregion

        #region Üreme Ekle butonu
        private void btnEkleUreme_Click(object sender, EventArgs e)
        {
            uremeBusiness = new UremeBusiness();
            ureme = new Ureme();
            try
            {
                ureme.SonDogurmaTarih = txtSonDogum.Value;
                ureme.SonKizginlikTarih = txtSonKizginlik.Value;
                ureme.SonTohumlanmaTarih = txtSonTohumlanma.Value;
                ureme.BogaID = Convert.ToInt32(txtBogaID.Text);
                ureme.PersonelID = Convert.ToInt32(cbxPersonel.SelectedValue);
                if (txtTohumlamaSayi.Text == null)
                {
                    ureme.TohumlamaSayi = 0;
                }
                else
                {
                    ureme.TohumlamaSayi = Convert.ToInt16(txtTohumlamaSayi.Text);
                }

                if (rdbKontrolYapildi.Checked is true)
                    ureme.GebelikKontrolYapildiMi = true;
                if (rdbYapilmadi.Checked is true)
                    ureme.GebelikKontrolYapildiMi = false;

                if (cbxGebelikSonucu.Text == "GEBE")
                    ureme.GebelikKontrolSonuc = true;
                if (cbxGebelikSonucu.Text == "GEBE DEĞİL")
                    ureme.GebelikKontrolSonuc = false;

                ureme.TahminDogurmaTarih = txtTahminiDogurma.Value;


                ureme.ServisPeriyod = Convert.ToInt16(txtServisPeriyodu.Text);
                ureme.HayvanID = Convert.ToInt32(txtHayvanIdUreme.Text);
                uremeBusiness.Ekle(ureme);
                MessageBox.Show("Üreme bilgisi eklenmiştir");
                UremeListele();
                TemizleUreme();

            }
            catch
            {
                MessageBox.Show("Gerekli Alanları doldurunuz");

            }

        }

        #endregion
        #region Servis periyodu hesaplama
        private void txtSonTohumlanma_ValueChanged(object sender, EventArgs e)
        {
            // servis periyodu hesaplama
            TimeSpan fark = txtSonTohumlanma.Value - txtSonDogum.Value;
            double gun = fark.TotalDays;
            txtServisPeriyodu.Text = gun.ToString();
        }

        #endregion

        #region Tahmini doğurma tarihi hesaplama
        private void cbxGebelikSonucu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGebelikSonucu.Text == "GEBE")
            {
                txtTahminiDogurma.Value = txtSonTohumlanma.Value.AddDays(280);
            }
            if (cbxGebelikSonucu.Text == "GEBE DEĞİL")
            {
                txtTahminiDogurma.Enabled = false;
            }
        }

        #endregion

        #region Ureme Güncelle butonu
        private void btnGuncelleUreme_Click(object sender, EventArgs e)
        {
            uremeBusiness = new UremeBusiness();
            ureme = new Ureme();
            try
            {
                ureme.ID = Convert.ToInt32(lblIDUreme.Text);
                ureme.SonDogurmaTarih = txtSonDogum.Value;
                ureme.SonKizginlikTarih = txtSonKizginlik.Value;
                ureme.SonTohumlanmaTarih = txtSonTohumlanma.Value;
                ureme.BogaID = Convert.ToInt32(txtBogaID.Text);
                ureme.PersonelID = Convert.ToInt32(cbxPersonel.SelectedValue);
                if (txtTohumlamaSayi.Text == null)
                {
                    ureme.TohumlamaSayi = 0;
                }
                else
                {
                    ureme.TohumlamaSayi = Convert.ToInt16(txtTohumlamaSayi.Text);
                }

                if (rdbKontrolYapildi.Checked is true)
                    ureme.GebelikKontrolYapildiMi = true;
                if (rdbYapilmadi.Checked is true)
                    ureme.GebelikKontrolYapildiMi = false;

                if (cbxGebelikSonucu.Text == "GEBE")
                    ureme.GebelikKontrolSonuc = true;
                if (cbxGebelikSonucu.Text == "GEBE DEĞİL")
                    ureme.GebelikKontrolSonuc = false;

                ureme.TahminDogurmaTarih = txtTahminiDogurma.Value;
                ureme.ServisPeriyod = Convert.ToInt16(txtServisPeriyodu.Text);
                ureme.HayvanID = Convert.ToInt32(txtHayvanIdUreme.Text);
                uremeBusiness.Guncelle(ureme);
                MessageBox.Show($"{ureme.HayvanID} nolu hayvana ait üreme bilgisi güncellendi");
                UremeListele();
                TemizleUreme();

            }
            catch
            {
                MessageBox.Show("Gerekli Alanları doldurunuz");

            }
        }

        #endregion

        #region DatagridViewUreme kayıtlarının textbox ve diğer alanlara getirilmesi
        private void dataGridViewUreme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUreme.CurrentRow.Cells[0].Value == null) lblIDUreme.Text = string.Empty;
            else lblIDUreme.Text = dataGridViewUreme.CurrentRow.Cells[0].Value.ToString();

            if (dataGridViewUreme.CurrentRow.Cells[1].Value == null) txtSonDogum.Value = Convert.ToDateTime(null);
            else txtSonDogum.Value = Convert.ToDateTime(dataGridViewUreme.CurrentRow.Cells[1].Value);

            if (dataGridViewUreme.CurrentRow.Cells[2].Value == null) txtSonKizginlik.Value = Convert.ToDateTime(null);
            else txtSonKizginlik.Value = Convert.ToDateTime(dataGridViewUreme.CurrentRow.Cells[2].Value);

            if (dataGridViewUreme.CurrentRow.Cells[3].Value == null) txtSonTohumlanma.Value = Convert.ToDateTime(null);
            else txtSonTohumlanma.Value = Convert.ToDateTime(dataGridViewUreme.CurrentRow.Cells[2].Value);

            if (dataGridViewUreme.CurrentRow.Cells[4].Value == null) txtBogaID.Text = string.Empty;
            else txtBogaID.Text = dataGridViewUreme.CurrentRow.Cells[4].Value.ToString();

            if (dataGridViewUreme.CurrentRow.Cells[5].Value == null) cbxPersonel.Text = string.Empty;
            else cbxPersonel.Text = dataGridViewUreme.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewUreme.CurrentRow.Cells[6].Value == null) txtTohumlamaSayi.Text = string.Empty;
            else txtTohumlamaSayi.Text = dataGridViewUreme.CurrentRow.Cells[6].Value.ToString();

            if (dataGridViewUreme.CurrentRow.Cells[7].Value == null)
            {
                rdbYapilmadi.Checked = false;
                rdbKontrolYapildi.Checked = false;
            }
            else txtBogaID.Text = dataGridViewUreme.CurrentRow.Cells[7].Value.ToString();

            if (dataGridViewUreme.CurrentRow.Cells[8].Value == null) cbxGebelikSonucu.Text = string.Empty;
            else cbxGebelikSonucu.Text = dataGridViewUreme.CurrentRow.Cells[8].Value.ToString();

            if (dataGridViewUreme.CurrentRow.Cells[9].Value == null) txtTahminiDogurma.Value = Convert.ToDateTime(null);
            else txtTahminiDogurma.Value = Convert.ToDateTime(dataGridViewUreme.CurrentRow.Cells[9].Value);

            if (dataGridViewUreme.CurrentRow.Cells[10].Value == null) txtServisPeriyodu.Text = string.Empty;
            else txtServisPeriyodu.Text = dataGridViewUreme.CurrentRow.Cells[10].Value.ToString();

            if (dataGridViewUreme.CurrentRow.Cells[11].Value == null) txtHayvanIdUreme.Text = string.Empty;
            else txtHayvanIdUreme.Text = dataGridViewUreme.CurrentRow.Cells[11].Value.ToString();



        }

        #endregion
        #region Laktasyon Güncelle butonu
        private void btnGuncelleLakt_Click_1(object sender, EventArgs e)
        {
            laktasyon = new Laktasyon();
            laktasyonBusiness = new LaktasyonBusiness();
            try
            {
                laktasyon.ID = Convert.ToInt32(lblLaktID.Text);
                if (rdbLaktasyonda.Checked is true)
                    laktasyon.Durum = true;
                if (rdbKuruda.Checked is true)
                    laktasyon.Durum = false;
                laktasyon.LaktSira = Convert.ToInt16(txtKacinciLaktasyon.Text);
                laktasyon.LaktBasTarih = txtLakBasTarih.Value;
                laktasyon.LaktBitTarih = txtLakBitTarih.Value;
                laktasyon.LaktSuresi = Convert.ToInt16(txtLakSuresi.Text);
                laktasyon.GunOrtSutVer = Convert.ToInt16(txtGunOrtSut.Text);
                laktasyon.LakSutVer = Convert.ToInt16(txtLakSut.Text);
                laktasyon.SutYagOran = Convert.ToDouble(txtSutYagOrani.Text);
                laktasyon.HayvanID = Convert.ToInt32(txtIDHayvan.Text);


                laktasyonBusiness.Guncelle(laktasyon);
                MessageBox.Show($"{laktasyon.HayvanID} ID nolu hayvana ait laktasyon bilgisi güncellendi");
                LaktasyonListele();
            }
            catch
            {

                MessageBox.Show("Güncellecenk veri bulunmadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Ureme Temizle butonu
        private void btnTemizleUreme_Click(object sender, EventArgs e)
        {
            TemizleUreme();
        }

        #endregion

        #region Ureme YeniKayıt butonu
        private void btnYeniKayitUreme_Click(object sender, EventArgs e)
        {
            TemizleUreme();
        }

        #endregion

        #region Ureme Sil butonu
        private void btnSilUreme_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblIDUreme.Text);
            var UremeSil = uremeBusiness.HepsiniGetir().Where(w => w.ID == id).FirstOrDefault();
            uremeBusiness.Sil(UremeSil);
            MessageBox.Show($"{id} nolu ureme kaydı silindi");
            UremeListele();
            TemizleUreme();
        }

        #endregion

        #region Doğum Ekle butonu
        private void btnEkleDogum_Click(object sender, EventArgs e)
        {
            dogumBusiness = new DogumBusiness();
            dogum = new Dogum();
            try
            {
                dogum.KacinciDogum = Convert.ToInt16(txtKacinciDogum.Text);
                dogum.KuruyaAlmaTarih = txtKuruAlmaTarih.Value;
                dogum.KurudaKalmaSuresi = Convert.ToInt16(txtKurudaKalmaSure.Text);
                dogum.DogurmaTarih = txtDogurmaTarih.Value;
                dogum.DogumSekli = cbxDogumSekliDogum.Text;
                dogum.DogumTipi = cbxDogumTipiDogum.Text;
                dogum.YavruCinsiyet = cbxYavruCinsiyet.Text;
                dogum.DogumAgirlik = Convert.ToInt16(txtYavruDogumAgirlik.Text);
                if (rdbCanliDogumEvet.Checked is true) dogum.CanliDogumMu = true;
                if (rdbCanliDogumHayir.Checked is true) dogum.CanliDogumMu = false;
                dogum.HayvanID = Convert.ToInt32(txtDogumHayvanID.Text);

                dogumBusiness.Ekle(dogum);
                MessageBox.Show("Doğum bilgisi eklendi");
                DogumListele();
            }
            catch
            {
                MessageBox.Show("Eklenecek bilgileri doldurunuz!");

            }


        }

        #endregion
        #region Kuruda kalma süresi hesaplama
        private void btnKuruSuresiHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan fark = txtDogurmaTarih.Value - txtKuruAlmaTarih.Value;
            double gun = fark.TotalDays;
            txtKurudaKalmaSure.Text = gun.ToString("#");
        }
        #endregion

        #region DatagridViewDogum daki verilerin textboxlara getirilmesi
        private void dataGridViewDogum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDogum.CurrentRow.Cells[0].Value == null) lblDogumID.Text = string.Empty;
            else lblDogumID.Text = dataGridViewDogum.CurrentRow.Cells[0].Value.ToString();

            if (dataGridViewDogum.CurrentRow.Cells[1].Value == null) txtKacinciDogum.Text = string.Empty;
            else txtKacinciDogum.Text = dataGridViewDogum.CurrentRow.Cells[1].Value.ToString();

            if (dataGridViewDogum.CurrentRow.Cells[2].Value == null) txtKuruAlmaTarih.Value = DateTime.Today;
            else txtKuruAlmaTarih.Value = Convert.ToDateTime(dataGridViewDogum.CurrentRow.Cells[2].Value);

            if (dataGridViewDogum.CurrentRow.Cells[3].Value == null) txtKurudaKalmaSure.Text = String.Empty;
            else txtKurudaKalmaSure.Text = dataGridViewDogum.CurrentRow.Cells[3].Value.ToString();

            if (dataGridViewDogum.CurrentRow.Cells[4].Value == null) txtDogurmaTarih.Value = DateTime.Today;
            else txtDogurmaTarih.Value = Convert.ToDateTime(dataGridViewDogum.CurrentRow.Cells[4].Value);

            if (dataGridViewDogum.CurrentRow.Cells[5].Value == null) cbxDogumSekliDogum.Text = string.Empty;
            else cbxDogumSekliDogum.Text = dataGridViewDogum.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewDogum.CurrentRow.Cells[6].Value == null) cbxDogumTipiDogum.Text = string.Empty;
            else cbxDogumTipiDogum.Text = dataGridViewDogum.CurrentRow.Cells[6].Value.ToString();

            if (dataGridViewDogum.CurrentRow.Cells[7].Value == null) cbxYavruCinsiyet.Text = string.Empty;
            else cbxYavruCinsiyet.Text = dataGridViewDogum.CurrentRow.Cells[7].Value.ToString();

            if (dataGridViewDogum.CurrentRow.Cells[8].Value == null) txtYavruDogumAgirlik.Text = string.Empty;
            else txtYavruDogumAgirlik.Text = dataGridViewDogum.CurrentRow.Cells[8].Value.ToString();

            if (dataGridViewDogum.CurrentRow.Cells[9].Value == null)
            {
                rdbCanliDogumEvet.Checked = false;
                rdbCanliDogumHayir.Checked = false;
            }
            if (dataGridViewDogum.CurrentRow.Cells[9].Value is true) rdbCanliDogumEvet.Checked = true;
            if (dataGridViewDogum.CurrentRow.Cells[9].Value is false) rdbCanliDogumHayir.Checked = true;

            if (dataGridViewDogum.CurrentRow.Cells[10].Value == null) txtDogumHayvanID.Text = string.Empty;
            else txtDogumHayvanID.Text = dataGridViewDogum.CurrentRow.Cells[10].Value.ToString();


        }

        #endregion

        #region Doğum Güncelle butonu
        private void btnGuncelleDogum_Click(object sender, EventArgs e)
        {
            try
            {
                dogumBusiness = new DogumBusiness();
                dogum = new Dogum();
                dogum.ID = Convert.ToInt32(lblDogumID.Text);
                dogum.KacinciDogum = Convert.ToInt16(txtKacinciDogum.Text);
                dogum.KuruyaAlmaTarih = txtKuruAlmaTarih.Value;
                dogum.KurudaKalmaSuresi = Convert.ToInt16(txtKurudaKalmaSure.Text);
                dogum.DogurmaTarih = txtDogurmaTarih.Value;
                dogum.DogumSekli = cbxDogumSekliDogum.Text;
                dogum.DogumTipi = cbxDogumTipiDogum.Text;
                dogum.YavruCinsiyet = cbxYavruCinsiyet.Text;
                dogum.DogumAgirlik = Convert.ToInt16(txtYavruDogumAgirlik.Text);
                if (rdbCanliDogumEvet.Checked is true) dogum.CanliDogumMu = true;
                if (rdbCanliDogumHayir.Checked is true) dogum.CanliDogumMu = false;
                dogum.HayvanID = Convert.ToInt32(txtDogumHayvanID.Text);

                dogumBusiness.Guncelle(dogum);
                MessageBox.Show("Doğum bilgisi güncellendi");
                DogumListele();
            }
            catch
            {
                MessageBox.Show("Değişiklik yapılmadı!");

            }

        }

        #endregion
        #region DoğumSil butonu
        private void btnSilDogum_Click(object sender, EventArgs e)
        {
            dogumBusiness = new DogumBusiness();
            dogum = new Dogum();
            dogum.ID = Convert.ToInt32(lblDogumID.Text);
            dogumBusiness.Sil(dogum);
            MessageBox.Show("Kayıt Silindi");
            DogumListele();
        }

        #endregion

        #region Doğum Temizle butonu
        private void btnTemizleDogum_Click(object sender, EventArgs e)
        {
            DogumTemizle();
        }

        #endregion

        #region Doğum Yeni Kayıt butonu
        private void btnYeniKayitDogum_Click(object sender, EventArgs e)
        {
            DogumTemizle();
        }

        #endregion

        #region Sağlık Ekle butonu
        private void btnSaglikEkle_Click(object sender, EventArgs e)
        {
            saglik = new Saglik();
            saglikBusiness = new SaglikBusiness();
            saglik.Tarih = txtHastalikTarihi.Value;
            saglik.HastalikAdi = txtHastalikAdi.Text;
            saglik.Belirtiler = txtBelirtiler.Text;
            saglik.UygulananTedavi = txtTedavi.Text;
            saglik.KullanilanIlaclar = txtİlaclar.Text;
            saglik.Durum = cbxDurum.Text;
            saglik.PersonelID = (int)(cbxSaglikPersonel.SelectedValue);
            saglik.HayvanID = Convert.ToInt32(txtSaglikHayvanID.Text);

            saglikBusiness.Ekle(saglik);
            MessageBox.Show("Sağlık bilgisi eklendi");
            SaglikListele();
            SaglikTemizle();
        }

        #endregion

        #region datagridviewSaglik daki verilerin textbox lara getirilmesi
        private void dataGridViewSaglik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSaglik.CurrentRow.Cells[0].Value == null) lblSaglikID.Text = string.Empty;
            else lblSaglikID.Text = dataGridViewSaglik.CurrentRow.Cells[0].Value.ToString();

            if (dataGridViewSaglik.CurrentRow.Cells[1].Value == null) txtHastalikTarihi.Value = DateTime.Today;
            else txtHastalikTarihi.Value = Convert.ToDateTime(dataGridViewSaglik.CurrentRow.Cells[1].Value);

            if (dataGridViewSaglik.CurrentRow.Cells[2].Value == null) txtHastalikAdi.Text = string.Empty;
            else txtHastalikAdi.Text = dataGridViewSaglik.CurrentRow.Cells[2].Value.ToString();

            if (dataGridViewSaglik.CurrentRow.Cells[3].Value == null) txtBelirtiler.Text = string.Empty;
            else txtBelirtiler.Text = dataGridViewSaglik.CurrentRow.Cells[3].Value.ToString();

            if (dataGridViewSaglik.CurrentRow.Cells[4].Value == null) txtTedavi.Text = string.Empty;
            else txtTedavi.Text = dataGridViewSaglik.CurrentRow.Cells[4].Value.ToString();

            if (dataGridViewSaglik.CurrentRow.Cells[5].Value == null) txtİlaclar.Text = string.Empty;
            else txtİlaclar.Text = dataGridViewSaglik.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewSaglik.CurrentRow.Cells[6].Value == null) cbxDurum.Text = string.Empty;
            else cbxDurum.Text = dataGridViewSaglik.CurrentRow.Cells[6].Value.ToString();

            if (dataGridViewSaglik.CurrentRow.Cells[7].Value == null) cbxSaglikPersonel.Text = string.Empty;
            else cbxSaglikPersonel.SelectedItem = dataGridViewSaglik.CurrentRow.Cells[7].Value;

            if (dataGridViewSaglik.CurrentRow.Cells[8].Value == null) txtSaglikHayvanID.Text = string.Empty;
            else txtSaglikHayvanID.Text = dataGridViewSaglik.CurrentRow.Cells[8].Value.ToString();

        }

        #endregion

        #region Saglık Güncelle butonu
        private void btnSaglikGuncelle_Click(object sender, EventArgs e)
        {
            saglik = new Saglik();
            saglikBusiness = new SaglikBusiness();

            saglik.ID = Convert.ToInt32(lblSaglikID.Text);
            saglik.Tarih = txtHastalikTarihi.Value;
            saglik.HastalikAdi = txtHastalikAdi.Text;
            saglik.Belirtiler = txtBelirtiler.Text;
            saglik.UygulananTedavi = txtTedavi.Text;
            saglik.KullanilanIlaclar = txtİlaclar.Text;
            saglik.Durum = cbxDurum.Text;
            saglik.PersonelID = (int)(cbxSaglikPersonel.SelectedValue);
            saglik.HayvanID = Convert.ToInt32(txtSaglikHayvanID.Text);

            saglikBusiness.Guncelle(saglik);
            MessageBox.Show($"{saglik.HayvanID} ID nolu hayvana ait sağlık bilgisi güncellendi");
            SaglikListele();
            SaglikTemizle();

        }

        #endregion

        #region Sağlık Sil butonu
        private void btnSaglikSil_Click(object sender, EventArgs e)
        {
            saglik = new Saglik();
            saglik.ID = Convert.ToInt32(lblSaglikID.Text);
            saglikBusiness = new SaglikBusiness();
            saglikBusiness.Sil(saglik);
            MessageBox.Show("Sağlık bilgisi silindi");
            SaglikListele();
            SaglikTemizle();

        }

        #endregion
        #region Sağlık Temizle butonu
        private void btnSaglikTemizle_Click(object sender, EventArgs e)
        {
            SaglikTemizle();
        }

        #endregion

        #region Sağlık Yeni Kayıt butonu
        private void btnSaglikYeniKayit_Click(object sender, EventArgs e)
        {
            SaglikTemizle();
        }

        #endregion

        #region HayvanAra butonu
        private void txtHayvanBul_Click(object sender, EventArgs e)
        {

            if (txtHayvaanAra.Text != string.Empty)
            {
                int id = Convert.ToInt32(txtHayvaanAra.Text);
                var queryHayvanAra = hayvanBusiness.HepsiniGetir().Where(w => w.HayvanID == id);
                dataGridViewGenel.DataSource = queryHayvanAra.ToList();
            }
            if (txtHayvaanAra.Text == string.Empty)
            {

                HayvanlariListele();
            }
        }

        #endregion

        #region DatagridViewAsilama bilgilerinin textbox lara getirilmesi
        private void dataGridViewAsilama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAsilama.CurrentRow.Cells[0].Value == null) lblAsiID.Text = string.Empty;
            else lblAsiID.Text = dataGridViewAsilama.CurrentRow.Cells[0].Value.ToString();

            if (dataGridViewAsilama.CurrentRow.Cells[1].Value == null) txtAsiAdi.Text = string.Empty;
            else txtAsiAdi.Text = dataGridViewAsilama.CurrentRow.Cells[1].Value.ToString();

            if (dataGridViewAsilama.CurrentRow.Cells[2].Value == null) txtAsiAmac.Text = string.Empty;
            else txtAsiAmac.Text = dataGridViewAsilama.CurrentRow.Cells[2].Value.ToString();

            if (dataGridViewAsilama.CurrentRow.Cells[3].Value == null) txtAsiUygulamaSekli.Text = string.Empty;
            else txtAsiUygulamaSekli.Text = dataGridViewAsilama.CurrentRow.Cells[3].Value.ToString();

            if (dataGridViewAsilama.CurrentRow.Cells[4].Value == null) txtAsiTarih.Value = DateTime.Today;
            else txtAsiTarih.Value = Convert.ToDateTime(dataGridViewAsilama.CurrentRow.Cells[4].Value);

            if (dataGridViewAsilama.CurrentRow.Cells[5].Value == null) txtAsiDoz.Text = string.Empty;
            else txtAsiDoz.Text = dataGridViewAsilama.CurrentRow.Cells[5].Value.ToString();

            if (dataGridViewAsilama.CurrentRow.Cells[6].Value == null) cbxAsiPersonel.Text = string.Empty;
            else cbxAsiPersonel.SelectedValue = dataGridViewAsilama.CurrentRow.Cells[6].Value.ToString();

            if (dataGridViewAsilama.CurrentRow.Cells[7].Value == null) txtAsiHayvanID.Text = string.Empty;
            else txtAsiHayvanID.Text = dataGridViewAsilama.CurrentRow.Cells[7].Value.ToString();


        }

        #endregion

        #region Aşılama Ekle butonu
        private void btnAsiEkle_Click(object sender, EventArgs e)
        {
            asilama = new Asilama();
            asilamaBusiness = new AsilamaBusiness();
            asilama.AsiAdi = txtAsiAdi.Text;
            asilama.YapilisAmaci = txtAsiAmac.Text;
            asilama.UygulamaSekli = txtAsiUygulamaSekli.Text;
            asilama.UygulamaTarih = txtAsiTarih.Value;
            asilama.UygulananDoz = Convert.ToInt16(txtAsiDoz.Text);
            asilama.PersonelID = (int)cbxAsiPersonel.SelectedValue;
            asilama.HayvanID = Convert.ToInt32(txtAsiHayvanID.Text);

            asilamaBusiness.Ekle(asilama);
            MessageBox.Show("Aşılama bilgisi eklendi");
            AsilamaListele();

        }

        #endregion

        #region Aşılama Güncelle butonu
        private void btnAsiGuncelle_Click(object sender, EventArgs e)
        {
            asilama = new Asilama();
            asilamaBusiness = new AsilamaBusiness();
            asilama.ID = Convert.ToInt32(lblAsiID.Text);
            asilama.AsiAdi = txtAsiAdi.Text;
            asilama.YapilisAmaci = txtAsiAmac.Text;
            asilama.UygulamaSekli = txtAsiUygulamaSekli.Text;
            asilama.UygulamaTarih = txtAsiTarih.Value;
            asilama.UygulananDoz = Convert.ToInt16(txtAsiDoz.Text);
            asilama.PersonelID = (int)cbxAsiPersonel.SelectedValue;
            asilama.HayvanID = Convert.ToInt32(txtAsiHayvanID.Text);

            asilamaBusiness.Guncelle(asilama);
            MessageBox.Show("Aşılama bilgisi güncellendi");
            AsilamaListele();
        }

        #endregion

        #region Aşılama Sil butonu
        private void btnAsiSil_Click(object sender, EventArgs e)
        {

            asilama = new Asilama();
            asilamaBusiness = new AsilamaBusiness();
            asilama.ID = Convert.ToInt32(lblAsiID.Text);

            asilamaBusiness.Sil(asilama);
            MessageBox.Show("Aşı bilgisi silindi");
            AsilamaListele();

        }

        #endregion
        #region Aşılama Temizle butonu
        private void btnAsiTemizle_Click(object sender, EventArgs e)
        {
            AsilamaTemizle();
        }

        #endregion
        #region Aşılama Yeni Kayıt butonu
        private void btnAsiYeniKayit_Click(object sender, EventArgs e)
        {
            AsilamaTemizle();
        }

        #endregion

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Hide();
        }

    }
}
