using NoteCode.Model.Context;
using NoteCode.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCode
{
    public partial class FrmKodNotlar : Form
    {
        public FrmKodNotlar()
        {
            InitializeComponent();
        }

        NoteCodeDbContext dbContext = new NoteCodeDbContext();
        void Temizle()
        {
            txtAltKonuID.Text = string.Empty;
            txtAltKonu.Text = string.Empty;
            txtDetay.Text = string.Empty;
            txtKullanimAlani.Text = string.Empty;
            txtSozDizimi.Text = string.Empty;
            cbxDersler.Text = string.Empty;
            cbxKonular.Text = string.Empty;

        }
        private void FrmKodNotlar_Load(object sender, EventArgs e)
        {
            panelMenu.Width = 65;
            btnMenuKucult.Visible = false;

            #region Alt konuların listBox da listelenmesi

            this.altKonusTableAdapter.Fill(this.nodeCodeDbDataSet.AltKonus);

            #endregion


            #region Dersler, Konular ve Alt Konular tablolarını birleştirmek
            var tablolar = from ak in dbContext.AltKonular
                           join a in dbContext.Konular on ak.Konuid equals a.KonuID
                           join d in dbContext.Dersler on ak.Dersid equals d.DersID
                           select new
                           {

                               ID = ak.AltKonuID,
                               AltKonu = ak.AltKonuAd,
                               Konu = a.KonuAdi,
                               Dil = d.DersAdi,
                               Detay = ak.Detay,
                               Kullanım_Alanı = ak.KullanimAlani,
                               Örnek_Kod = ak.OrnekKod,
                               Söz_Dizimi = ak.SozDizimi,
                               Tarih = ak.Tarih
                           };
            dgvKodNotlar.DataSource = tablolar.ToList();
            #endregion

            #region Derslerin combobox da listelenmesi
            cbxDersler.DataSource = dbContext.Dersler.ToList();
            cbxDersler.DisplayMember = "DersAdi";
            cbxDersler.ValueMember = "DersID";
            #endregion

        }
        #region Dersler seçilince konuların combobox larda listelenmesi
        private void cbxDersler_ValueMemberChanged(object sender, EventArgs e)
        {
            var konuGetir = dbContext.Konular.Where(w => w.Dersid == (int)cbxDersler.SelectedValue).ToList();
            cbxKonular.DataSource = konuGetir;
            cbxKonular.DisplayMember = "KonuAdi";
            cbxKonular.ValueMember = "KonuID";
        }
        #endregion
        #region AltKonu Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            AltKonu Ekle = new AltKonu();
            Ekle.AltKonuAd = txtAltKonu.Text;
            Ekle.Detay = txtDetay.Text;
            Ekle.KullanimAlani = txtKullanimAlani.Text;
            Ekle.OrnekKod = pictureBoxOrnekKod.ImageLocation;
            Ekle.SozDizimi = txtSozDizimi.Text;
            Ekle.Tarih = dateTimePicker1.Value;
            Ekle.Dersid = (int)cbxDersler.SelectedValue;
            Ekle.Konuid = (int)cbxKonular.SelectedValue;

            dbContext.AltKonular.Add(Ekle);
            dbContext.SaveChanges();
            MessageBox.Show("Kayıt Tamamlandı");
            Listele();
            this.altKonusTableAdapter.Fill(this.nodeCodeDbDataSet.AltKonus);

            Temizle();



        }

        private void Listele()
        {
            var tablolar = from ak in dbContext.AltKonular
                           join a in dbContext.Konular on ak.Konuid equals a.KonuID
                           join d in dbContext.Dersler on ak.Dersid equals d.DersID
                           select new
                           {

                               ID = ak.AltKonuID,
                               AltKonu = ak.AltKonuAd,
                               Konu = a.KonuAdi,
                               Dil = d.DersAdi,
                               Detay = ak.Detay,
                               Kullanım_Alanı = ak.KullanimAlani,
                               Örnek_Kod = ak.OrnekKod,
                               Söz_Dizimi = ak.SozDizimi,
                               Tarih = ak.Tarih
                           };
            dgvKodNotlar.DataSource = tablolar.ToList();
        }
        #endregion

        #region Fotoğraf yükleme
        private void btnFotoEkle_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxOrnekKod.ImageLocation = openFileDialog1.FileName;
            }
        }
        #endregion
        #region Fotoğrafı kaldırma
        private void btnFotoSil_Click(object sender, EventArgs e)
        {
            pictureBoxOrnekKod.ImageLocation = "";

        }
        #endregion

        #region Alanların dolu gelmesi
        private void dgvKodNotlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAltKonuID.Text = dgvKodNotlar.CurrentRow.Cells[0].Value.ToString();
            txtAltKonu.Text = dgvKodNotlar.CurrentRow.Cells[1].Value.ToString();
            cbxKonular.Text = dgvKodNotlar.CurrentRow.Cells[2].Value.ToString();
            cbxDersler.Text = dgvKodNotlar.CurrentRow.Cells[3].Value.ToString();
            txtDetay.Text = dgvKodNotlar.CurrentRow.Cells[4].Value.ToString();
            txtKullanimAlani.Text = dgvKodNotlar.CurrentRow.Cells[5].Value.ToString();
            txtSozDizimi.Text = dgvKodNotlar.CurrentRow.Cells[7].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvKodNotlar.CurrentRow.Cells[8].Value.ToString());
            listBoxAltKonular.SelectedValue = dgvKodNotlar.CurrentRow.Cells[1].Value.ToString();



        }
        #endregion
        #region Altkonu sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvKodNotlar.CurrentRow.Cells[0].Value.ToString());
            var sil = dbContext.AltKonular.Where(w => w.AltKonuID == id).FirstOrDefault();
            dbContext.AltKonular.Remove(sil);
            dbContext.SaveChanges();
            MessageBox.Show("Kayıt Silindi");
            Listele();
            this.altKonusTableAdapter.Fill(this.nodeCodeDbDataSet.AltKonus);

            Temizle();
        }
        #endregion
        #region Altkonu güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvKodNotlar.CurrentRow.Cells[0].Value.ToString());
            var Guncelle = dbContext.AltKonular.Where(w => w.AltKonuID == id).FirstOrDefault();
            Guncelle.AltKonuAd = txtAltKonu.Text;
            Guncelle.Detay = txtDetay.Text;
            Guncelle.KullanimAlani = txtKullanimAlani.Text;
            Guncelle.OrnekKod = pictureBoxOrnekKod.ImageLocation;
            Guncelle.SozDizimi = txtSozDizimi.Text;
            Guncelle.Tarih = dateTimePicker1.Value;


            dbContext.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi");
            Listele();
            this.altKonusTableAdapter.Fill(this.nodeCodeDbDataSet.AltKonus);
            Temizle();

        }
        #endregion


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuBuyut_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 150;
            btnMenuKucult.Visible = true;
            btnMenuBuyut.Visible = false;
        }

        private void btnMenuKucult_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 65;
            btnMenuBuyut.Visible = true;
            btnMenuKucult.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKonular frmKonular = new FrmKonular();
            frmKonular.Show();
        }

    }
}
