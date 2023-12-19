
namespace CRMapp.UI
{
    partial class FrmMusteri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İletisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriUrunler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iletisimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedeniDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meslek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtiletisimId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.cbxMedeniDurum = new System.Windows.Forms.ComboBox();
            this.btnMusteriUrunleri = new System.Windows.Forms.Button();
            this.dataGridViewMusteriUrunleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriUrunleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.İletisim,
            this.MusteriUrunler,
            this.iletisimId,
            this.Ad,
            this.Soyad,
            this.DogumTarih,
            this.Cinsiyet,
            this.MedeniDurum,
            this.Meslek});
            this.dataGridView1.Location = new System.Drawing.Point(31, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(657, 159);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // İletisim
            // 
            this.İletisim.DataPropertyName = "İletisim";
            this.İletisim.HeaderText = "İletisim";
            this.İletisim.MinimumWidth = 6;
            this.İletisim.Name = "İletisim";
            this.İletisim.Visible = false;
            // 
            // MusteriUrunler
            // 
            this.MusteriUrunler.DataPropertyName = "MusteriUrunler";
            this.MusteriUrunler.HeaderText = "MusteriUrunler";
            this.MusteriUrunler.MinimumWidth = 6;
            this.MusteriUrunler.Name = "MusteriUrunler";
            this.MusteriUrunler.Visible = false;
            // 
            // iletisimId
            // 
            this.iletisimId.DataPropertyName = "iletisimId";
            this.iletisimId.HeaderText = "İletişim ID";
            this.iletisimId.MinimumWidth = 6;
            this.iletisimId.Name = "iletisimId";
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            // 
            // DogumTarih
            // 
            this.DogumTarih.DataPropertyName = "DogumTarih";
            this.DogumTarih.HeaderText = "Doğum Tarihi";
            this.DogumTarih.MinimumWidth = 6;
            this.DogumTarih.Name = "DogumTarih";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DataPropertyName = "Cinsiyet";
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.MinimumWidth = 6;
            this.Cinsiyet.Name = "Cinsiyet";
            // 
            // MedeniDurum
            // 
            this.MedeniDurum.DataPropertyName = "MedeniDurum";
            this.MedeniDurum.HeaderText = "Medeni Durum";
            this.MedeniDurum.MinimumWidth = 6;
            this.MedeniDurum.Name = "MedeniDurum";
            // 
            // Meslek
            // 
            this.Meslek.DataPropertyName = "Meslek";
            this.Meslek.HeaderText = "Meslek";
            this.Meslek.MinimumWidth = 6;
            this.Meslek.Name = "Meslek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 179);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 27);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "İletişim ID :";
            // 
            // txtiletisimId
            // 
            this.txtiletisimId.Location = new System.Drawing.Point(120, 215);
            this.txtiletisimId.Name = "txtiletisimId";
            this.txtiletisimId.Size = new System.Drawing.Size(52, 27);
            this.txtiletisimId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meslek :";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(418, 187);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(125, 27);
            this.txtMeslek.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 251);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 27);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 284);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(125, 27);
            this.txtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cinsiyet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Medeni Durum :";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(594, 183);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(94, 29);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "YENi";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(594, 218);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 29);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "EKLE";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(594, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 29);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(594, 288);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(418, 221);
            this.txtDogumTarihi.Mask = "00/00/0000";
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(125, 27);
            this.txtDogumTarihi.TabIndex = 7;
            this.txtDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(418, 255);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(125, 28);
            this.cbxCinsiyet.TabIndex = 8;
            // 
            // cbxMedeniDurum
            // 
            this.cbxMedeniDurum.FormattingEnabled = true;
            this.cbxMedeniDurum.Items.AddRange(new object[] {
            "EVLİ",
            "BEKAR"});
            this.cbxMedeniDurum.Location = new System.Drawing.Point(418, 290);
            this.cbxMedeniDurum.Name = "cbxMedeniDurum";
            this.cbxMedeniDurum.Size = new System.Drawing.Size(125, 28);
            this.cbxMedeniDurum.TabIndex = 8;
            // 
            // btnMusteriUrunleri
            // 
            this.btnMusteriUrunleri.Location = new System.Drawing.Point(158, 352);
            this.btnMusteriUrunleri.Name = "btnMusteriUrunleri";
            this.btnMusteriUrunleri.Size = new System.Drawing.Size(360, 29);
            this.btnMusteriUrunleri.TabIndex = 9;
            this.btnMusteriUrunleri.Text = "Müşteri Ürünleri";
            this.btnMusteriUrunleri.UseVisualStyleBackColor = true;
            this.btnMusteriUrunleri.Click += new System.EventHandler(this.btnMusteriUrunleri_Click);
            // 
            // dataGridViewMusteriUrunleri
            // 
            this.dataGridViewMusteriUrunleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriUrunleri.Location = new System.Drawing.Point(31, 387);
            this.dataGridViewMusteriUrunleri.Name = "dataGridViewMusteriUrunleri";
            this.dataGridViewMusteriUrunleri.RowHeadersWidth = 51;
            this.dataGridViewMusteriUrunleri.RowTemplate.Height = 29;
            this.dataGridViewMusteriUrunleri.Size = new System.Drawing.Size(657, 125);
            this.dataGridViewMusteriUrunleri.TabIndex = 10;
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 539);
            this.Controls.Add(this.dataGridViewMusteriUrunleri);
            this.Controls.Add(this.btnMusteriUrunleri);
            this.Controls.Add(this.cbxMedeniDurum);
            this.Controls.Add(this.cbxCinsiyet);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtMeslek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtiletisimId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriUrunleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtiletisimId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MaskedTextBox txtDogumTarihi;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.ComboBox cbxMedeniDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn İletisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn iletisimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedeniDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meslek;
        private System.Windows.Forms.Button btnMusteriUrunleri;
        private System.Windows.Forms.DataGridView dataGridViewMusteriUrunleri;
    }
}

