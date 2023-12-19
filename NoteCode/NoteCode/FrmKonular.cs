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
    public partial class FrmKonular : Form
    {
        public FrmKonular()
        {
            InitializeComponent();
        }

        NoteCodeDbContext dbContext = new NoteCodeDbContext();
        void Listele()
        {
            dgvKonular.DataSource = dbContext.Konular.ToList();
        }
        void Temizle()
        {
            txtKonuID.Text = string.Empty;
            txtKonu.Text = string.Empty;
            cbxDersler.Text = string.Empty;
        }

        private void FrmKonular_Load(object sender, EventArgs e)
        {
            panelMenu.Width = 65;
            Listele();

            dgvKonular.Columns[3].Visible = false;


            cbxDersler.DataSource = dbContext.Dersler.ToList();
            cbxDersler.DisplayMember = "DersAdi";
            cbxDersler.ValueMember = "DersID";

        }
        #region Konu Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {

            Konu konuEkle = new Konu();
            konuEkle.KonuAdi = txtKonu.Text;
            konuEkle.Dersid = (int)cbxDersler.SelectedValue;
            dbContext.Konular.Add(konuEkle);
            dbContext.SaveChanges();
            MessageBox.Show("Konu Eklendi");
            Listele();
            Temizle();
        }
        #endregion
        #region Konu Güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvKonular.CurrentRow.Cells[0].Value.ToString());
            var Guncelle = dbContext.Konular.Where(w => w.KonuID == id).FirstOrDefault();
            Guncelle.KonuAdi = txtKonu.Text;
            Guncelle.Dersid =(int)cbxDersler.SelectedValue;
            dbContext.SaveChanges();
            MessageBox.Show("Konu Güncellendi");
            Listele();
            Temizle();
        }
        #endregion
        #region Alanları doldurma
        private void dgvKonular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKonuID.Text = dgvKonular.CurrentRow.Cells[0].Value.ToString();
            txtKonu.Text = dgvKonular.CurrentRow.Cells[1].Value.ToString();
            cbxDersler.SelectedValue = dgvKonular.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion
        #region Konu Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id =int.Parse(dgvKonular.CurrentRow.Cells[0].Value.ToString());
            var konuSil = dbContext.Konular.Where(w => w.KonuID == id).FirstOrDefault();
            dbContext.Konular.Remove(konuSil);
            dbContext.SaveChanges();
            MessageBox.Show("Konu Silindi");
            Listele();
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
    }
}
