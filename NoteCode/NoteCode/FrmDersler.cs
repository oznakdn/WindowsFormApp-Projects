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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        NoteCodeDbContext dbContext = new NoteCodeDbContext();
        void Listele()
        {
            dgvDersler.DataSource = dbContext.Dersler.ToList();
        }
        void Temizle()
        {
            txtDersID.Text = string.Empty;
            txtDers.Text = string.Empty;
            cbxTur.Text = string.Empty;
        }
        private void FrmDersler_Load(object sender, EventArgs e)
        {

            panelMenu.Width = 65;
            btnMenuKucult.Visible = false;
            Listele();
            dgvDersler.Columns[3].Visible = false;
            dgvDersler.Columns[4].Visible = false;

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
        #region Ders Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ders dersEkle = new Ders();
            dersEkle.DersAdi = txtDers.Text;
            dersEkle.Tur = cbxTur.Text;

            dbContext.Dersler.Add(dersEkle);
            dbContext.SaveChanges();
            MessageBox.Show("Dil Eklendi");
            Listele();
            Temizle();
        }
        #endregion
        #region Ders Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDersler.CurrentRow.Cells[0].Value.ToString());
            var dersSil = dbContext.Dersler.Where(w => w.DersID == id).FirstOrDefault();
            dbContext.Dersler.Remove(dersSil);
            dbContext.SaveChanges();
            MessageBox.Show("Dil Silindi");
            Listele();
            Temizle();
        }
        #endregion
        #region Alanları doldurmak
        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersID.Text = dgvDersler.CurrentRow.Cells[0].Value.ToString();
            txtDers.Text = dgvDersler.CurrentRow.Cells[1].Value.ToString();
            cbxTur.Text = dgvDersler.CurrentRow.Cells[2].Value.ToString();

        }
        #endregion
        #region Ders Güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDersler.CurrentRow.Cells[0].Value.ToString());
            var dersGuncelle = dbContext.Dersler.Where(w => w.DersID == id).FirstOrDefault();
            dersGuncelle.DersAdi = txtDers.Text;
            dersGuncelle.Tur = cbxTur.Text;
            dbContext.SaveChanges();
            MessageBox.Show("Dil Güncellendi");
            Listele();
            Temizle();
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
