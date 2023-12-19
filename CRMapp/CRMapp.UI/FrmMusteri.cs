using CRMapp.BusinessLogicLayer.Concrete;
using CRMapp.DataAccessLayer.Concrete;
using CRMapp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMapp.UI
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        //Dependency Injection uygulandı
        MusteriService musteriService = new MusteriService(new MusteriRepository());
        MusteriUrunService musteriUrunService = new MusteriUrunService(new MusteriUrunRepository());
      
        Musteri musteri = new Musteri();
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            Listele();
           

            // Form açıldığında yeni kayıt başlatılır
            Data_Bindings(new Musteri());

        }
        // Listele metodu
        private void Listele()
        {
            dataGridView1.DataSource = musteriService.GetAll();
        }

        // Data Bindings temizleme metodu
        private void clearData_Bindings()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        // Data Binding metodu
        private void Data_Bindings(Musteri _musteri)
        {
            clearData_Bindings();
            musteri = _musteri;
            
           
            txtId.DataBindings.Add("Text", musteri, "Id", true);
            txtiletisimId.DataBindings.Add("Text", musteri, "iletisimId", true);
            txtAd.DataBindings.Add("Text", musteri, "Ad", true);
            txtSoyad.DataBindings.Add("Text", musteri, "Soyad", true);
            txtMeslek.DataBindings.Add("Text", musteri, "Meslek", true);
            txtDogumTarihi.DataBindings.Add("Text", musteri, "DogumTarih", true);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Data_Bindings(musteriService.GetByFilter(w => w.Id == id));


            // Data_Bindings metoduna eklenemeyen bilgileri manuel yazıyoruz.(veri tipi bool olduğundan)
            if (musteri.MedeniDurum == true) cbxMedeniDurum.Text = "EVLİ";
            else cbxMedeniDurum.Text = "BEKAR";

            if (musteri.Cinsiyet == true) cbxCinsiyet.Text = "KADIN";
            else cbxCinsiyet.Text = "ERKEK";


        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Bindings(new Musteri());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Data_Bindings metoduna eklenemeyen bilgileri manuel yazıyoruz.(veri tipi bool olduğundan)

            if (cbxMedeniDurum.Text == "EVLİ") musteri.MedeniDurum = true;
            else musteri.MedeniDurum = false;

            if (cbxCinsiyet.Text == "KADIN") musteri.Cinsiyet = true;
            else musteri.Cinsiyet = false;

            musteriService.Add(musteri);
            MessageBox.Show("Kayıt başarıyla eklendi");
            Listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            // Data_Bindings metoduna eklenemeyen bilgileri manuel yazıyoruz.(veri tipi bool olduğundan)
            if (cbxMedeniDurum.Text == "EVLİ") musteri.MedeniDurum = true;
            else musteri.MedeniDurum = false;

            if (cbxCinsiyet.Text == "KADIN") musteri.Cinsiyet = true;
            else musteri.Cinsiyet = false;

            musteriService.Update(musteri);
            MessageBox.Show($"{musteri.Id} nolu Id'ye ait Kayıt güncellendi");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                musteriService.Delete(id);
                MessageBox.Show($"{id} nolu Id kaydı silindi");
                Listele();
            }
           
        }

        private void btnMusteriUrunleri_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridViewMusteriUrunleri.DataSource = musteriUrunService.GetAll();
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                dataGridViewMusteriUrunleri.DataSource = musteriUrunService.GetByFilter(w => w.MusteriId == id);
            }
            
        }
    }
}
