using MyFarmYS.BLL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KullaniciBusiness kullaniciBusiness;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGoster.Checked is true) txtSifre.UseSystemPasswordChar = false;
            else txtSifre.UseSystemPasswordChar = true;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKullanici frmKullanici = new FrmKullanici();
            frmKullanici.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            kullaniciBusiness = new KullaniciBusiness();
            var query = kullaniciBusiness.HepsiniGetir().Where(w => w.KullaniciAdi == txtKullaniciAdi.Text && w.Sifre == txtSifre.Text);
            if (query.Any())
            {
                MessageBox.Show("Giriş Başarılı");
                FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
                frmAnaMenu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
                txtKullaniciAdi.Text = string.Empty;
                txtSifre.Text = string.Empty;
            }

        }
    }
}
