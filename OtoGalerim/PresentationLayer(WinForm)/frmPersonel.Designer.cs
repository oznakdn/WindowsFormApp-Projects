
namespace PresentationLayer_WinForm_
{
    partial class frmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMedeniDurum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGirisTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalismaYili = new System.Windows.Forms.TextBox();
            this.pictureBoxPersonel = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDigerOdeme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtToplamOdeme = new System.Windows.Forms.TextBox();
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnFotoSil = new System.Windows.Forms.Button();
            this.btnFotoYukle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtPersonelAra);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtPersonelAra
            // 
            this.txtPersonelAra.BackColor = System.Drawing.SystemColors.Control;
            this.txtPersonelAra.Location = new System.Drawing.Point(513, 32);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(125, 22);
            this.txtPersonelAra.TabIndex = 13;
            this.txtPersonelAra.TextChanged += new System.EventHandler(this.txtPersonelAra_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(410, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Personel Ara :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtAdSoyad.Location = new System.Drawing.Point(150, 218);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(125, 22);
            this.txtAdSoyad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(60, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad Soyad :";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtPersonelID.Location = new System.Drawing.Point(150, 192);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(65, 22);
            this.txtPersonelID.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label13.Location = new System.Drawing.Point(110, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label3.Location = new System.Drawing.Point(579, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Görev :";
            // 
            // txtGorev
            // 
            this.txtGorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtGorev.Location = new System.Drawing.Point(646, 202);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(125, 22);
            this.txtGorev.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label4.Location = new System.Drawing.Point(71, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cinsiyet :";
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(150, 247);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(125, 24);
            this.cbxCinsiyet.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label5.Location = new System.Drawing.Point(24, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Medeni Durum :";
            // 
            // cbxMedeniDurum
            // 
            this.cbxMedeniDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.cbxMedeniDurum.FormattingEnabled = true;
            this.cbxMedeniDurum.Items.AddRange(new object[] {
            "EVLİ",
            "BEKAR"});
            this.cbxMedeniDurum.Location = new System.Drawing.Point(150, 276);
            this.cbxMedeniDurum.Name = "cbxMedeniDurum";
            this.cbxMedeniDurum.Size = new System.Drawing.Size(125, 24);
            this.cbxMedeniDurum.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label6.Location = new System.Drawing.Point(551, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giriş Tarihi :";
            // 
            // txtGirisTarih
            // 
            this.txtGirisTarih.Location = new System.Drawing.Point(646, 143);
            this.txtGirisTarih.Name = "txtGirisTarih";
            this.txtGirisTarih.Size = new System.Drawing.Size(125, 22);
            this.txtGirisTarih.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label7.Location = new System.Drawing.Point(542, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Çalışma Yılı :";
            // 
            // txtCalismaYili
            // 
            this.txtCalismaYili.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtCalismaYili.Location = new System.Drawing.Point(646, 173);
            this.txtCalismaYili.Name = "txtCalismaYili";
            this.txtCalismaYili.Size = new System.Drawing.Size(125, 22);
            this.txtCalismaYili.TabIndex = 13;
            // 
            // pictureBoxPersonel
            // 
            this.pictureBoxPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPersonel.Location = new System.Drawing.Point(325, 142);
            this.pictureBoxPersonel.Name = "pictureBoxPersonel";
            this.pictureBoxPersonel.Size = new System.Drawing.Size(130, 127);
            this.pictureBoxPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPersonel.TabIndex = 17;
            this.pictureBoxPersonel.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label8.Location = new System.Drawing.Point(582, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Maaş :";
            // 
            // txtMaas
            // 
            this.txtMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtMaas.Location = new System.Drawing.Point(646, 230);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(125, 22);
            this.txtMaas.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label9.Location = new System.Drawing.Point(509, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Diğer Ödemeler :";
            // 
            // txtDigerOdeme
            // 
            this.txtDigerOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtDigerOdeme.Location = new System.Drawing.Point(646, 258);
            this.txtDigerOdeme.Name = "txtDigerOdeme";
            this.txtDigerOdeme.Size = new System.Drawing.Size(125, 22);
            this.txtDigerOdeme.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label10.Location = new System.Drawing.Point(510, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Toplam Ödeme :";
            // 
            // txtToplamOdeme
            // 
            this.txtToplamOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtToplamOdeme.Enabled = false;
            this.txtToplamOdeme.Location = new System.Drawing.Point(646, 286);
            this.txtToplamOdeme.Name = "txtToplamOdeme";
            this.txtToplamOdeme.Size = new System.Drawing.Size(125, 22);
            this.txtToplamOdeme.TabIndex = 13;
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(113)))), ((int)(((byte)(149)))));
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(12, 331);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.RowHeadersWidth = 51;
            this.dataGridViewPersoneller.RowTemplate.Height = 24;
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(611, 150);
            this.dataGridViewPersoneller.TabIndex = 20;
            this.dataGridViewPersoneller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersoneller_CellClick);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnYeni.Location = new System.Drawing.Point(629, 331);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(144, 46);
            this.btnYeni.TabIndex = 25;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnKaydet.Location = new System.Drawing.Point(629, 383);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(144, 46);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnSil.Location = new System.Drawing.Point(629, 435);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 46);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnFotoSil
            // 
            this.btnFotoSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnFotoSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoSil.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnFotoSil.Location = new System.Drawing.Point(410, 275);
            this.btnFotoSil.Name = "btnFotoSil";
            this.btnFotoSil.Size = new System.Drawing.Size(45, 27);
            this.btnFotoSil.TabIndex = 26;
            this.btnFotoSil.Text = "Sil";
            this.btnFotoSil.UseVisualStyleBackColor = false;
            this.btnFotoSil.Click += new System.EventHandler(this.btnFotoSil_Click);
            // 
            // btnFotoYukle
            // 
            this.btnFotoYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnFotoYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoYukle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoYukle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnFotoYukle.Location = new System.Drawing.Point(327, 275);
            this.btnFotoYukle.Name = "btnFotoYukle";
            this.btnFotoYukle.Size = new System.Drawing.Size(77, 27);
            this.btnFotoYukle.TabIndex = 27;
            this.btnFotoYukle.Text = "Yükle";
            this.btnFotoYukle.UseVisualStyleBackColor = false;
            this.btnFotoYukle.Click += new System.EventHandler(this.btnFotoYukle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 493);
            this.Controls.Add(this.btnFotoSil);
            this.Controls.Add(this.btnFotoYukle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Controls.Add(this.pictureBoxPersonel);
            this.Controls.Add(this.txtGirisTarih);
            this.Controls.Add(this.cbxMedeniDurum);
            this.Controls.Add(this.cbxCinsiyet);
            this.Controls.Add(this.txtToplamOdeme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDigerOdeme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCalismaYili);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMedeniDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtGirisTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalismaYili;
        private System.Windows.Forms.PictureBox pictureBoxPersonel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDigerOdeme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtToplamOdeme;
        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFotoSil;
        private System.Windows.Forms.Button btnFotoYukle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}