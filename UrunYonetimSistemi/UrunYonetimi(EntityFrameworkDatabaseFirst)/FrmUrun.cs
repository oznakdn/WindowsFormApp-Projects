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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        UrunYonetimiDBEntities dbContext = new UrunYonetimiDBEntities();
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            Listele();

            cbxKategori.DataSource = dbContext.KategoriTb.ToList();
            cbxKategori.DisplayMember = "KategoriAdi";
            cbxKategori.ValueMember = "ID";

        }

        private void Listele()
        {
            var listele = from u in dbContext.UrunlerTb
                          join k in dbContext.KategoriTb on u.Kategoriid equals k.ID
                          select new
                          {
                              Ürün_ID = u.UrunID,
                              Ürün = u.UrunAdi,
                              Marka = u.Marka,
                              Stok_Miktarı = u.Stok,
                              Fiyat = u.Fiyat,
                              Durum = u.Durum,
                              Kategori = k.KategoriAdi
                          };
            dataGridView1.DataSource = listele.ToList();
        }
        #region Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunlerTb Ekle = new UrunlerTb();
            Ekle.UrunAdi = txtUrun.Text;
            Ekle.Marka = txtMarka.Text;
            Ekle.Stok = Convert.ToInt16(txtStok.Text);
            Ekle.Fiyat = decimal.Parse(txtFiyat.Text);
            Ekle.Kategoriid = (int)cbxKategori.SelectedValue;
            if (Ekle.Durum == true)
            {
                rdbStokta.Checked = true;
                rdbStoktaYok.Checked = false;
            }
            else if (Ekle.Durum == false)
            {
                rdbStoktaYok.Checked = true;
                rdbStokta.Checked = false;
            }
            dbContext.UrunlerTb.Add(Ekle);
            dbContext.SaveChanges();
            Listele();
            MessageBox.Show($"{Ekle.UrunAdi} adlı ürün eklenmiştir.");

        }
        #endregion
        #region Güncelle
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[0].Value;
            var Guncelle = dbContext.UrunlerTb.Find(id);
            Guncelle.UrunAdi = txtUrun.Text;
            Guncelle.Marka = txtMarka.Text;
            Guncelle.Stok = Convert.ToInt16(txtStok.Text);
            Guncelle.Fiyat = decimal.Parse(txtFiyat.Text);
            Guncelle.Kategoriid = (int)(cbxKategori.SelectedValue);

            if (rdbStokta.Checked)
                Guncelle.Durum = true;
            else if (rdbStoktaYok.Checked)
                Guncelle.Durum = false;
            dbContext.SaveChanges();
            MessageBox.Show("Ürün bilgileri güncellendi");
            Listele();


        }
        #endregion
        #region Alanları doldur
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUrun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[5].Value is true)
                rdbStokta.Checked = true;
            else rdbStoktaYok.Checked = true;
            cbxKategori.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
        #endregion
        #region Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var Sil = dbContext.UrunlerTb.Where(w => w.UrunID == id).FirstOrDefault();
            dbContext.UrunlerTb.Remove(Sil);
            dbContext.SaveChanges();
            MessageBox.Show($"{Sil.UrunAdi}ürünü silinmiştir.");
            Listele();
        }
        #endregion
        #region Temizle
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                if (item is ComboBox)
                    item.Text = string.Empty;
            }
        }
        #endregion

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
