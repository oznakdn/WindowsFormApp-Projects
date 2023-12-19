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
    public partial class frmAraclar : Form
    {
        public frmAraclar()
        {
            InitializeComponent();
        }

        Arac arac = new Arac();
        private void frmAraclar_Load(object sender, EventArgs e)
        {
            // Araç kayıtlarını datagridview'e getirir
            Listele();

            Data_Binding(new Arac());

        }

        private void Listele()
        {
            AracBLL aracBLL = new AracBLL();
            MarkaBLL markaBLL = new MarkaBLL();
            SeriBLL seriBLL = new SeriBLL();


            var tablo = from a in aracBLL.GetAll()
                        join m in markaBLL.GetAll() on a.MarkaId equals m.MarkaID
                        join s in seriBLL.GetAll() on m.MarkaID equals s.MarkaId
                        select new
                        {
                            a.AracID,
                            m.MarkaAd,
                            s.SeriAd,
                            a.ModelAd,
                            a.Yil,
                            a.Renk,
                            a.Yakit,
                            a.LpgDurum,
                            a.Vites,
                            a.KasaTipi,
                            a.Fotograf,
                            a.Kilometre,
                            a.MotorGucu,
                            a.MotorHacmi,
                            a.Cekis,
                            a.GarantiDurumu,
                            a.GelisTarih,
                            a.Durum,
                            a.Aciklama,
                            a.AlisFiyati,
                            a.SatisFiyati
                        };

            dataGridViewAraclar.DataSource = tablo.ToList();
        }

        private void btnFotoYukle_Click(object sender, EventArgs e)
        {
            // Araç fotoğrafı yüklemek
            if (openFileDialog1.ShowDialog() == DialogResult.OK) picAracFoto.ImageLocation = openFileDialog1.FileName;
        }

        private void btnFotoSil_Click(object sender, EventArgs e)
        {
            // Araç fotoğrafını kaldırmak için
            picAracFoto.ImageLocation = string.Empty;
        }
        void ClearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }

        void Data_Binding(Arac _arac)
        {
            ClearDataBinding();
            this.arac = _arac;
            txtAracId.DataBindings.Add("Text", arac, "AracID", true);
            cbxMarka.DataBindings.Add("SelectedValue", arac, "MarkaID", true);
            cbxSeri.DataBindings.Add("SelectedValue", arac, "SeriID", true);
            txtModel.DataBindings.Add("Text", arac, "ModelAd", true);
            txtYil.DataBindings.Add("Text", arac, "Yil", true);
            txtRenk.DataBindings.Add("Text", arac, "Renk", true);
            txtYakit.DataBindings.Add("Text", arac, "Yakit", true);
            checkBoxLpgVar.DataBindings.Add("CheckState", arac, "LpgDurum", true);
            cbxVites.DataBindings.Add("Text", arac, "Vites", true);
            cbxKasa.DataBindings.Add("Text", arac, "KasaTipi", true);
            picAracFoto.DataBindings.Add("Text", arac, "Fotograf", true);
            txtKilometre.DataBindings.Add("Text", arac, "Kilometre", true);
            txtMotorGucu.DataBindings.Add("Text", arac, "MotorGucu", true);
            txtMotorHacmi.DataBindings.Add("Text", arac, "MotorHacmi", true);
            cbxCekis.DataBindings.Add("Text", arac, "Cekis", true);
            checkBoxGaranti.DataBindings.Add("CheckState", arac, "GarantiDurumu", true);
            txtGelisTarih.DataBindings.Add("Text", arac, "GelisTarih", true);
            checkBoxDurum.DataBindings.Add("CheckState", arac, "Durum", true);
            txtAciklama.DataBindings.Add("Text", arac, "Aciklama", true);
            txtAlisFiyat.DataBindings.Add("Text", arac, "AlisFiyati", true);
            txtSatisFiyat.DataBindings.Add("Text", arac, "SatisFiyati", true);


        }

        private void dataGridViewAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAraclar.CurrentRow.Cells["AracID"].Value);

            using (AracBLL aracBLL = new AracBLL())
            {
                Data_Binding(aracBLL.GetbyFilter(w => w.AracID == id));

            }
            btnSatisYap.Enabled = true;

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

            Data_Binding(new Arac());
            // Markaların cbx marka da listelenmesi
            using (MarkaBLL markaBLL = new MarkaBLL())
            {
                cbxMarka.DataSource = markaBLL.GetAll();
            }

            // Marka seçince serilerin getirilmesi
            using (SeriBLL seriBLL = new SeriBLL())
            {
                var seriGetir = seriBLL.GetAll().Where(w => w.SeriID == (int)cbxMarka.SelectedValue);
                cbxSeri.DataSource = seriGetir.ToList();

            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (AracBLL aracBLL = new AracBLL())
            {
                aracBLL.AddorUpdate(arac);
                aracBLL.Save();
            }
            Listele();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAraclar.CurrentRow.Cells["AracID"].Value);
            using (AracBLL aracBLL = new AracBLL())
            {

                aracBLL.Delete(w => w.AracID == id);
                aracBLL.Save();
            }
            Listele();

            MessageBox.Show("Kayıt silindi");
            Data_Binding(new Arac());
        }

        private void cbxSeri_Click(object sender, EventArgs e)
        {
            using (SeriBLL seriBLL = new SeriBLL())
            {
                var seriGetir = seriBLL.GetAll().Where(w => w.SeriID == (int)cbxMarka.SelectedValue);
                cbxSeri.DataSource = seriGetir.ToList();

            }
        }

        private void txtAracBul_TextChanged(object sender, EventArgs e)
        {
            using (AracBLL aracBLL = new AracBLL())
            {

                dataGridViewAraclar.DataSource = aracBLL.GetAll(w => w.ModelAd.Contains(txtAracBul.Text));

            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {

            frmSatislar frmSatislar = new frmSatislar();
            frmSatislar.Show();
            frmSatislar.txtSatisAracID.Text = dataGridViewAraclar.CurrentRow.Cells["AracID"].Value.ToString();
            frmSatislar.txtSatisSatisTutari.Text = dataGridViewAraclar.CurrentRow.Cells["SatisFiyati"].Value.ToString();
            foreach (Control item in frmSatislar.Controls)
            {
                item.Enabled = false;
                frmSatislar.btnSatisBilgileri.Enabled = true;
            }
            


        }
    }
}
