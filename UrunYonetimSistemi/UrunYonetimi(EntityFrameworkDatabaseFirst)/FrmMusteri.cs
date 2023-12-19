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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        UrunYonetimiDBEntities dbContext = new UrunYonetimiDBEntities();
        void Listele()
        {
            dataGridView1.DataSource = dbContext.MusterilerTb.ToList();
        }
        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
            }
        }
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            Listele();
        }
        #region Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusterilerTb Ekle = new MusterilerTb();
            Ekle.MusteriAdi = txtAdi.Text;
            Ekle.MusteriSoyadi = txtSoyadi.Text;
            Ekle.Sehir = cbxSehir.Text;
            dbContext.MusterilerTb.Add(Ekle);
            dbContext.SaveChanges();
            MessageBox.Show($"{Ekle.MusteriAdi} {Ekle.MusteriSoyadi} adlı müşteri eklendi");
            Listele();
            Temizle();
        }
        #endregion
        #region Temizle
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        #endregion
        #region Alanları doldur
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxSehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        #endregion
        #region Güncelle
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var Guncelle = dbContext.MusterilerTb.Find(id);
            Guncelle.MusteriAdi = txtAdi.Text;
            Guncelle.MusteriSoyadi = txtSoyadi.Text;
            Guncelle.Sehir = cbxSehir.Text;
            dbContext.SaveChanges();
            Listele();
            MessageBox.Show($"{id} nolu müşteri güncellendi.");
            Temizle();
        }
        #endregion
        #region Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var Sil = dbContext.MusterilerTb.Where(w => w.MusteriID == id).FirstOrDefault();
            dbContext.MusterilerTb.Remove(Sil);
            dbContext.SaveChanges();
            MessageBox.Show($"{id} nolu {dataGridView1.CurrentRow.Cells[1].Value} {dataGridView1.CurrentRow.Cells[2].Value} adlı müşteri silindi.");
            Listele();
            Temizle();
        }
        #endregion

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
