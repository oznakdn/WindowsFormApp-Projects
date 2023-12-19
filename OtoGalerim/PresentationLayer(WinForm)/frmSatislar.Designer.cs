
namespace PresentationLayer_WinForm_
{
    partial class frmSatislar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatislar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSatisAracID = new System.Windows.Forms.TextBox();
            this.dataGridViewSatislar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMusteri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxKapora = new System.Windows.Forms.CheckBox();
            this.txtKaporaTutar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKalanTutar = new System.Windows.Forms.TextBox();
            this.txtSatisSatisTutari = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxOdemeTuru = new System.Windows.Forms.ComboBox();
            this.cbxPersonel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSatisBilgileri = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSatisTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtKaporaTarih = new System.Windows.Forms.MaskedTextBox();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.btnSatislar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 110);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satışlar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(56, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID :";
            // 
            // txtSatisID
            // 
            this.txtSatisID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtSatisID.Enabled = false;
            this.txtSatisID.Location = new System.Drawing.Point(92, 180);
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.Size = new System.Drawing.Size(101, 22);
            this.txtSatisID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Araç ID :";
            // 
            // txtSatisAracID
            // 
            this.txtSatisAracID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtSatisAracID.Location = new System.Drawing.Point(92, 208);
            this.txtSatisAracID.Name = "txtSatisAracID";
            this.txtSatisAracID.Size = new System.Drawing.Size(101, 22);
            this.txtSatisAracID.TabIndex = 8;
            // 
            // dataGridViewSatislar
            // 
            this.dataGridViewSatislar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(113)))), ((int)(((byte)(149)))));
            this.dataGridViewSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatislar.Location = new System.Drawing.Point(31, 313);
            this.dataGridViewSatislar.Name = "dataGridViewSatislar";
            this.dataGridViewSatislar.RowHeadersWidth = 51;
            this.dataGridViewSatislar.RowTemplate.Height = 24;
            this.dataGridViewSatislar.Size = new System.Drawing.Size(795, 150);
            this.dataGridViewSatislar.TabIndex = 20;
            this.dataGridViewSatislar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSatislar_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(19, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri :";
            // 
            // cbxMusteri
            // 
            this.cbxMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.cbxMusteri.DisplayMember = "MusteriAdSoyad";
            this.cbxMusteri.FormattingEnabled = true;
            this.cbxMusteri.Location = new System.Drawing.Point(92, 237);
            this.cbxMusteri.Name = "cbxMusteri";
            this.cbxMusteri.Size = new System.Drawing.Size(200, 24);
            this.cbxMusteri.TabIndex = 21;
            this.cbxMusteri.ValueMember = "MusteriID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(39, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(392, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kapora :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(353, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kapora Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(357, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kapora Tutarı :";
            // 
            // checkBoxKapora
            // 
            this.checkBoxKapora.AutoSize = true;
            this.checkBoxKapora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.checkBoxKapora.Location = new System.Drawing.Point(470, 128);
            this.checkBoxKapora.Name = "checkBoxKapora";
            this.checkBoxKapora.Size = new System.Drawing.Size(18, 17);
            this.checkBoxKapora.TabIndex = 23;
            this.checkBoxKapora.UseVisualStyleBackColor = false;
            // 
            // txtKaporaTutar
            // 
            this.txtKaporaTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtKaporaTutar.Location = new System.Drawing.Point(469, 183);
            this.txtKaporaTutar.Name = "txtKaporaTutar";
            this.txtKaporaTutar.Size = new System.Drawing.Size(99, 22);
            this.txtKaporaTutar.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(372, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Kalan Tuar :";
            // 
            // txtKalanTutar
            // 
            this.txtKalanTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtKalanTutar.Location = new System.Drawing.Point(469, 237);
            this.txtKalanTutar.Name = "txtKalanTutar";
            this.txtKalanTutar.Size = new System.Drawing.Size(99, 22);
            this.txtKalanTutar.TabIndex = 25;
            // 
            // txtSatisSatisTutari
            // 
            this.txtSatisSatisTutari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtSatisSatisTutari.Location = new System.Drawing.Point(469, 210);
            this.txtSatisSatisTutari.Name = "txtSatisSatisTutari";
            this.txtSatisSatisTutari.Size = new System.Drawing.Size(99, 22);
            this.txtSatisSatisTutari.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label10.Location = new System.Drawing.Point(375, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Satış Tutarı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label11.Location = new System.Drawing.Point(352, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ödeme Şekli :";
            // 
            // cbxOdemeTuru
            // 
            this.cbxOdemeTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.cbxOdemeTuru.FormattingEnabled = true;
            this.cbxOdemeTuru.Items.AddRange(new object[] {
            "Kredi",
            "Nakit"});
            this.cbxOdemeTuru.Location = new System.Drawing.Point(468, 264);
            this.cbxOdemeTuru.Name = "cbxOdemeTuru";
            this.cbxOdemeTuru.Size = new System.Drawing.Size(144, 24);
            this.cbxOdemeTuru.TabIndex = 26;
            // 
            // cbxPersonel
            // 
            this.cbxPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.cbxPersonel.DisplayMember = "AdSoyad";
            this.cbxPersonel.FormattingEnabled = true;
            this.cbxPersonel.Location = new System.Drawing.Point(92, 128);
            this.cbxPersonel.Name = "cbxPersonel";
            this.cbxPersonel.Size = new System.Drawing.Size(200, 24);
            this.cbxPersonel.TabIndex = 27;
            this.cbxPersonel.ValueMember = "PersonelID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label12.Location = new System.Drawing.Point(10, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Personel :";
            // 
            // btnSatisBilgileri
            // 
            this.btnSatisBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnSatisBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisBilgileri.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnSatisBilgileri.Location = new System.Drawing.Point(706, 127);
            this.btnSatisBilgileri.Name = "btnSatisBilgileri";
            this.btnSatisBilgileri.Size = new System.Drawing.Size(120, 64);
            this.btnSatisBilgileri.TabIndex = 30;
            this.btnSatisBilgileri.Text = "SATIŞ BİLGİLERİ GİR";
            this.btnSatisBilgileri.UseVisualStyleBackColor = false;
            this.btnSatisBilgileri.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnKaydet.Location = new System.Drawing.Point(706, 197);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 46);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "SAT";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnSil.Location = new System.Drawing.Point(706, 249);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 46);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSatisTarih
            // 
            this.txtSatisTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtSatisTarih.Location = new System.Drawing.Point(92, 265);
            this.txtSatisTarih.Mask = "00/00/0000";
            this.txtSatisTarih.Name = "txtSatisTarih";
            this.txtSatisTarih.Size = new System.Drawing.Size(100, 22);
            this.txtSatisTarih.TabIndex = 31;
            this.txtSatisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtKaporaTarih
            // 
            this.txtKaporaTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtKaporaTarih.Location = new System.Drawing.Point(468, 156);
            this.txtKaporaTarih.Mask = "00/00/0000";
            this.txtKaporaTarih.Name = "txtKaporaTarih";
            this.txtKaporaTarih.Size = new System.Drawing.Size(100, 22);
            this.txtKaporaTarih.TabIndex = 32;
            this.txtKaporaTarih.ValidatingType = typeof(System.DateTime);
            // 
            // btnSatislar
            // 
            this.btnSatislar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnSatislar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatislar.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatislar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnSatislar.Location = new System.Drawing.Point(706, 61);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(120, 34);
            this.btnSatislar.TabIndex = 31;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.UseVisualStyleBackColor = false;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 488);
            this.Controls.Add(this.txtKaporaTarih);
            this.Controls.Add(this.txtSatisTarih);
            this.Controls.Add(this.btnSatisBilgileri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cbxPersonel);
            this.Controls.Add(this.cbxOdemeTuru);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSatisSatisTutari);
            this.Controls.Add(this.txtKalanTutar);
            this.Controls.Add(this.checkBoxKapora);
            this.Controls.Add(this.cbxMusteri);
            this.Controls.Add(this.dataGridViewSatislar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKaporaTutar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSatisAracID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSatisID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSatislar";
            this.Load += new System.EventHandler(this.frmSatislar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatisID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxKapora;
        private System.Windows.Forms.TextBox txtKaporaTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKalanTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxOdemeTuru;
        private System.Windows.Forms.ComboBox cbxPersonel;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSatisAracID;
        public System.Windows.Forms.TextBox txtSatisSatisTutari;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MaskedTextBox txtSatisTarih;
        private System.Windows.Forms.MaskedTextBox txtKaporaTarih;
        public System.Windows.Forms.DataGridView dataGridViewSatislar;
        public System.Windows.Forms.Button btnSatisBilgileri;
        public System.Windows.Forms.Button btnSatislar;
    }
}