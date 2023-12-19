using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimi_EntityFrameworkDatabaseFirst_
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        UrunYonetimiDBEntities dbContext = new UrunYonetimiDBEntities();

        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Listele
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbContext.KategoriTb.ToList();

            dataGridView1.Columns[2].Visible = false;
           
        }
        #endregion
        #region Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            KategoriTb Ekle = new KategoriTb();
            Ekle.KategoriAdi = txtKategori.Text;
            dbContext.KategoriTb.Add(Ekle);
            dbContext.SaveChanges();
            MessageBox.Show($" Yeni kategori {Ekle.KategoriAdi} olarak eklendi.");
            Temizle();

        }
        #endregion
  
        #region Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriID.Text);
            var Sil = dbContext.KategoriTb.Where(w => w.ID == id).FirstOrDefault();
            dbContext.KategoriTb.Remove(Sil);
            dbContext.SaveChanges();
            MessageBox.Show($"{id} nolu kategori silindi");
            Temizle();

            /* İKİNCİ SİLME YÖNTEMİ
            int id = int.Parse(txtKategoriID.Text);
            var Sil = dbContext.KategoriTb.Find(id);
            dbContext.KategoriTb.Remove(Sil);
            dbContext.SaveChanges();
            */

        }
        #endregion
        #region Güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[0].Value;
            var Guncelle = dbContext.KategoriTb.Find(id);
            Guncelle.KategoriAdi = txtKategori.Text;
            dbContext.SaveChanges();
            MessageBox.Show($"{dataGridView1.CurrentRow.Cells[0].Value} nolu kategori {Guncelle.KategoriAdi} olarak güncellendi.");
            Temizle();

        }
        #endregion
        #region Alanları doldur
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKategori.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
        }
        #endregion

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
