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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }
        KullaniciBusiness kullaniciBusiness;
        Kullanici kullanici;
        private void FrmKullanici_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text==null||txtKullaniciAdi.Text==string.Empty && txtSifre.Text == null || txtSifre.Text==string.Empty)
            {
                MessageBox.Show("Lütfen Bilgileri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                kullaniciBusiness = new KullaniciBusiness();
                kullanici = new Kullanici();
                kullanici.Adi = txtAd.Text;
                kullanici.Soyadi = txtSoyad.Text;
                kullanici.KayitTarihi = txtKayitTarih.Value;
                kullanici.Gorevi = txtGorev.Text;
                kullanici.Yetkisi = txtYetki.Text;
                kullanici.KullaniciAdi = txtKullaniciAdi.Text;
                kullanici.Sifre = txtSifre.Text;
                kullaniciBusiness.Ekle(kullanici);
                MessageBox.Show("Kayıt başarıyla tamamlandı.");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
