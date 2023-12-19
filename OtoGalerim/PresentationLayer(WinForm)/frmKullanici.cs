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
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }
        Kullanici kullanici = new Kullanici();
        private void frmKullanici_Load(object sender, EventArgs e)
        {
            Data_Binding(new Kullanici());
           



        }
        void clearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.Controls.Clear();
            }
        }
            

        void Data_Binding(Kullanici _kullanici)
        {
            clearDataBinding();
            this.kullanici = _kullanici;
            txtKullaniciID.DataBindings.Add("Text", kullanici, "KullaniciID", true);
            txtAdSoyad.DataBindings.Add("Text", kullanici, "AdSoyad", true);
            cbxYetki.DataBindings.Add("Text", kullanici, "Yetki", true);
            txtKullaniciAdi.DataBindings.Add("Text", kullanici, "KullaniciAdi", true);
            txtsifre.DataBindings.Add("Text", kullanici, "Sifre", true);
        }


        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != string.Empty && cbxYetki.Text != string.Empty && txtKullaniciAdi.Text != string.Empty && txtsifre.Text != string.Empty)
            {
                using (KullaniciBLL kullaniciBLL = new KullaniciBLL())
                {
                    kullanici.KayitTarih = DateTime.Today;
                    kullaniciBLL.AddorUpdate(kullanici);
                    kullaniciBLL.Save();
                    MessageBox.Show("Kullanıcı Kaydı Başarılı");
                }
            }
            else
            {
                MessageBox.Show("Alanları doldurunuz");
            }
            

        }
    }
}
