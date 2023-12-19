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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        HayvanBusiness hayvanBusiness;
        LaktasyonBusiness laktasyonBusiness;
        SaglikBusiness saglikBusiness;
        UremeBusiness uremeBusiness;
        PersonelBusiness personelBusiness;
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            hayvanBusiness = new HayvanBusiness();
            laktasyonBusiness = new LaktasyonBusiness();
            saglikBusiness = new SaglikBusiness();
            uremeBusiness = new UremeBusiness();
            personelBusiness = new PersonelBusiness();

           
            // Toplam hayvan sayısı
            var toplamHayvan = hayvanBusiness.HepsiniGetir().Count;
            lblToplamHayvan.Text = toplamHayvan.ToString();

            // Dişi hayvan sayısı
            var disiHayvan = hayvanBusiness.HepsiniGetir().Count(w => w.Cinsiyet == "DİŞİ");
            lblDisiler.Text = disiHayvan.ToString();

            // Erkek hayvan sayısı
            var erkekHayvan = hayvanBusiness.HepsiniGetir().Count(w => w.Cinsiyet == "ERKEK");
            lblErkekler.Text = erkekHayvan.ToString();

            // Buzağı sayısı
            var buzagiSayisi = hayvanBusiness.HepsiniGetir().Count(w => w.Grup == "BUZAĞI");
            lblBuzagi.Text = buzagiSayisi.ToString();

            // Dana sayısı
            var danaSayisi = hayvanBusiness.HepsiniGetir().Count(w => w.Grup == "DANA");
            lblDana.Text = danaSayisi.ToString();

            // Düve sayısı
            var duveSayisi = hayvanBusiness.HepsiniGetir().Count(w => w.Grup == "DÜVE");
            lblDuve.Text = duveSayisi.ToString();

            // Tosun sayısı
            var tosunSayisi = hayvanBusiness.HepsiniGetir().Count(w => w.Grup == "TOSUN");
            lblTosun.Text = tosunSayisi.ToString();

            // Boğa sayısı
            var bogaSayisi = hayvanBusiness.HepsiniGetir().Count(w => w.Grup == "BOĞA");
            lblBoga.Text = bogaSayisi.ToString();

            // İnek sayısı
            var inekSayisi = hayvanBusiness.HepsiniGetir().Count(w => w.Grup == "İNEK");
            lblInek.Text = inekSayisi.ToString();


            // Laktasyondaki hayvanlar
            var laktasyondakiler = laktasyonBusiness.HepsiniGetir().Count(w => w.Durum == true && w.LaktSira==1);
            lblLaktasyonda.Text = laktasyondakiler.ToString();

            // Kurudaki hayvanlar
            var kurudakiler = laktasyonBusiness.HepsiniGetir().Count(w => w.Durum == false);
            lblKuruda.Text = kurudakiler.ToString();

            // Laktasyon süt verim ortalaması
            var sutVerimToplam = laktasyonBusiness.HepsiniGetir().Sum(w => w.LakSutVer);
            var hayvanSayisi = hayvanBusiness.HepsiniGetir().Count();
            lblLaktSutVerim.Text = (sutVerimToplam / hayvanSayisi).ToString();

            // Günlük süt verim ortalaması
            var gunlukToplamSut = laktasyonBusiness.HepsiniGetir().Sum(w => w.GunOrtSutVer);
            var laktasyonSayisi = laktasyonBusiness.HepsiniGetir().Count();
            lblOrtSutVerim.Text = (gunlukToplamSut / (hayvanSayisi + laktasyonSayisi)).ToString();

            // Laktasyon süresi ortalaması
            var laktSureToplam = laktasyonBusiness.HepsiniGetir().Sum(w => w.LaktSuresi);
            lblOrtLakSure.Text = (laktSureToplam / (hayvanSayisi+laktasyonSayisi)).ToString();

            //Hasta hayvan sayısı
            var hastaHayvan = saglikBusiness.HepsiniGetir().Count;
            lblHastaHayvan.Text = hastaHayvan.ToString();

            // Gebe hayvan sayısı
            var gebeHayvanlar = uremeBusiness.HepsiniGetir().Count(w => w.GebelikKontrolSonuc =true);
            lblGebeHayvan.Text = gebeHayvanlar.ToString();

            // Toplam çalışan sayısı
            var toplamCalisan = personelBusiness.HepsiniGetir().Count;
            lblToplamCalisan.Text = toplamCalisan.ToString();

            // Kadın çalışan
            var kadinCalisan = personelBusiness.HepsiniGetir().Count(w => w.Cinsiyet == "KADIN");
            lblKadinCalisan.Text = kadinCalisan.ToString();

            // Erkek çalışan
            var erkekCalisan = personelBusiness.HepsiniGetir().Count(w => w.Cinsiyet == "ERKEK");
            lblErkekCalisan.Text = erkekCalisan.ToString();

            // Evli çalışan
            var evliCalisan = personelBusiness.HepsiniGetir().Count(w => w.MedeniDurum == true);
            lblEvli.Text = evliCalisan.ToString();

            // Bekar çalışan
            var bekarCalisan = personelBusiness.HepsiniGetir().Count(w => w.MedeniDurum == false);
            lblBekar.Text = bekarCalisan.ToString();

            // Toplam maas
            var toplamMaas = personelBusiness.HepsiniGetir().Sum(w => w.Maas);
            lblToplamMaas.Text = toplamMaas.ToString();

            // Ortalama maaş
            var ortalamaMaas = personelBusiness.HepsiniGetir().Average(w => w.Maas);
            lblOrtalamaMaas.Text = ortalamaMaas.ToString();






        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();
            this.Hide();
        }
    }
}
