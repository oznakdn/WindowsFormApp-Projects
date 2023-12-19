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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        UrunYonetimiDBEntities dbContext = new UrunYonetimiDBEntities();
        private void Listele()
        {
            dataGridView1.DataSource = dbContext.SatislarTb.ToList();
        }
        private void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
            }
        }
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            cbxMusteri.DataSource = dbContext.MusterilerTb.ToList();
            // cbxMusteri.DisplayMember = "MusteriAdi";
            cbxMusteri.ValueMember = "MusteriID";

            cbxUrunler.DataSource = dbContext.UrunlerTb.ToList();
            // cbxUrunler.DisplayMember = "UrunAdi";
            cbxUrunler.ValueMember = "UrunID";

            Listele();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;





        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SatislarTb Ekle = new SatislarTb();
            Ekle.Fiyat = decimal.Parse(txtFiyat.Text);
            Ekle.Tarih = dtpTarih.Value;
            Ekle.UrunID = (int)cbxUrunler.SelectedValue;
            Ekle.MusteriID = (int)cbxMusteri.SelectedValue;
            dbContext.SatislarTb.Add(Ekle);
            dbContext.SaveChanges();
            MessageBox.Show("Satış eklendi.");
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
        #region Güncelle
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var Guncelle = dbContext.SatislarTb.Where(w => w.SatısID == id).FirstOrDefault();
            Guncelle.Fiyat = decimal.Parse(txtFiyat.Text);
            Guncelle.Tarih = dtpTarih.Value;
            Guncelle.MusteriID = (int)cbxMusteri.SelectedValue;
            Guncelle.UrunID = (int)cbxUrunler.SelectedValue;
            dbContext.SaveChanges();
            MessageBox.Show($"{id} nolu satış güncellendi");
            Listele();
            Temizle();
        }
        #endregion
        #region Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var Sil = dbContext.SatislarTb.Find(id);
            dbContext.SatislarTb.Remove(Sil);
            dbContext.SaveChanges();
            MessageBox.Show($"{id} nolu satış silindi");
            Listele();
            Temizle();
        }
        #endregion
        #region Alanları doldur
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSatisID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbxUrunler.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxMusteri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtpTarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            
        }
        #endregion
    }
}
