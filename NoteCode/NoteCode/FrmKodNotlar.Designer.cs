
namespace NoteCode
{
    partial class FrmKodNotlar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKodNotlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenuKucult = new System.Windows.Forms.PictureBox();
            this.btnMenuBuyut = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFotoSil = new System.Windows.Forms.Button();
            this.btnFotoEkle = new System.Windows.Forms.Button();
            this.pictureBoxOrnekKod = new System.Windows.Forms.PictureBox();
            this.txtDetay = new System.Windows.Forms.TextBox();
            this.txtSozDizimi = new System.Windows.Forms.TextBox();
            this.txtKullanimAlani = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxAltKonular = new System.Windows.Forms.ListBox();
            this.altKonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nodeCodeDbDataSet = new NoteCode.NodeCodeDbDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDersler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvKodNotlar = new System.Windows.Forms.DataGridView();
            this.cbxKonular = new System.Windows.Forms.ComboBox();
            this.txtAltKonu = new System.Windows.Forms.TextBox();
            this.txtAltKonuID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.altKonusTableAdapter = new NoteCode.NodeCodeDbDataSetTableAdapters.AltKonusTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuKucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuBuyut)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrnekKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altKonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeCodeDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 128);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1205, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnMenuKucult);
            this.panelMenu.Controls.Add(this.btnMenuBuyut);
            this.panelMenu.Controls.Add(this.btnGuncelle);
            this.panelMenu.Controls.Add(this.btnSil);
            this.panelMenu.Controls.Add(this.btnEkle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 128);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(266, 697);
            this.panelMenu.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.button3.Image = global::NoteCode.Properties.Resources.vision;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "KONU EKLE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.button2.Image = global::NoteCode.Properties.Resources.internet;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "DİL EKLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.button1.Image = global::NoteCode.Properties.Resources.eraser;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "TEMİZLE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenuKucult
            // 
            this.btnMenuKucult.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuKucult.Image")));
            this.btnMenuKucult.Location = new System.Drawing.Point(12, 6);
            this.btnMenuKucult.Name = "btnMenuKucult";
            this.btnMenuKucult.Size = new System.Drawing.Size(29, 29);
            this.btnMenuKucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenuKucult.TabIndex = 3;
            this.btnMenuKucult.TabStop = false;
            this.btnMenuKucult.Click += new System.EventHandler(this.btnMenuKucult_Click);
            // 
            // btnMenuBuyut
            // 
            this.btnMenuBuyut.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBuyut.Image")));
            this.btnMenuBuyut.Location = new System.Drawing.Point(12, 6);
            this.btnMenuBuyut.Name = "btnMenuBuyut";
            this.btnMenuBuyut.Size = new System.Drawing.Size(29, 29);
            this.btnMenuBuyut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenuBuyut.TabIndex = 2;
            this.btnMenuBuyut.TabStop = false;
            this.btnMenuBuyut.Click += new System.EventHandler(this.btnMenuBuyut_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnGuncelle.Image = global::NoteCode.Properties.Resources.refresh;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 227);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(180, 39);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(12, 182);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(180, 39);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnEkle.Image = global::NoteCode.Properties.Resources.ekle;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(12, 137);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 39);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.btnFotoSil);
            this.panel2.Controls.Add(this.btnFotoEkle);
            this.panel2.Controls.Add(this.pictureBoxOrnekKod);
            this.panel2.Controls.Add(this.txtDetay);
            this.panel2.Controls.Add(this.txtSozDizimi);
            this.panel2.Controls.Add(this.txtKullanimAlani);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.listBoxAltKonular);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbxDersler);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvKodNotlar);
            this.panel2.Controls.Add(this.cbxKonular);
            this.panel2.Controls.Add(this.txtAltKonu);
            this.panel2.Controls.Add(this.txtAltKonuID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(266, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 697);
            this.panel2.TabIndex = 4;
            // 
            // btnFotoSil
            // 
            this.btnFotoSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.btnFotoSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoSil.Image = ((System.Drawing.Image)(resources.GetObject("btnFotoSil.Image")));
            this.btnFotoSil.Location = new System.Drawing.Point(974, 55);
            this.btnFotoSil.Name = "btnFotoSil";
            this.btnFotoSil.Size = new System.Drawing.Size(53, 49);
            this.btnFotoSil.TabIndex = 22;
            this.btnFotoSil.UseVisualStyleBackColor = false;
            this.btnFotoSil.Click += new System.EventHandler(this.btnFotoSil_Click);
            // 
            // btnFotoEkle
            // 
            this.btnFotoEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.btnFotoEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnFotoEkle.Image")));
            this.btnFotoEkle.Location = new System.Drawing.Point(915, 55);
            this.btnFotoEkle.Name = "btnFotoEkle";
            this.btnFotoEkle.Size = new System.Drawing.Size(53, 49);
            this.btnFotoEkle.TabIndex = 21;
            this.btnFotoEkle.UseVisualStyleBackColor = false;
            this.btnFotoEkle.Click += new System.EventHandler(this.btnFotoEkle_Click);
            // 
            // pictureBoxOrnekKod
            // 
            this.pictureBoxOrnekKod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOrnekKod.Location = new System.Drawing.Point(786, 120);
            this.pictureBoxOrnekKod.Name = "pictureBoxOrnekKod";
            this.pictureBoxOrnekKod.Size = new System.Drawing.Size(368, 524);
            this.pictureBoxOrnekKod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrnekKod.TabIndex = 20;
            this.pictureBoxOrnekKod.TabStop = false;
            // 
            // txtDetay
            // 
            this.txtDetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDetay.Location = new System.Drawing.Point(402, 120);
            this.txtDetay.Multiline = true;
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.Size = new System.Drawing.Size(368, 385);
            this.txtDetay.TabIndex = 19;
            // 
            // txtSozDizimi
            // 
            this.txtSozDizimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSozDizimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSozDizimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSozDizimi.Location = new System.Drawing.Point(174, 386);
            this.txtSozDizimi.Multiline = true;
            this.txtSozDizimi.Name = "txtSozDizimi";
            this.txtSozDizimi.Size = new System.Drawing.Size(203, 119);
            this.txtSozDizimi.TabIndex = 18;
            // 
            // txtKullanimAlani
            // 
            this.txtKullanimAlani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullanimAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanimAlani.ForeColor = System.Drawing.Color.Red;
            this.txtKullanimAlani.Location = new System.Drawing.Point(174, 302);
            this.txtKullanimAlani.Multiline = true;
            this.txtKullanimAlani.Name = "txtKullanimAlani";
            this.txtKullanimAlani.Size = new System.Drawing.Size(202, 78);
            this.txtKullanimAlani.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(801, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Örnek Kod:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(406, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Detay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(56, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kullanım Alanı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Söz Dizimi (Syntax):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tarih:";
            // 
            // listBoxAltKonular
            // 
            this.listBoxAltKonular.DataSource = this.altKonusBindingSource;
            this.listBoxAltKonular.DisplayMember = "AltKonuAd";
            this.listBoxAltKonular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxAltKonular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listBoxAltKonular.FormattingEnabled = true;
            this.listBoxAltKonular.ItemHeight = 16;
            this.listBoxAltKonular.Location = new System.Drawing.Point(174, 212);
            this.listBoxAltKonular.Name = "listBoxAltKonular";
            this.listBoxAltKonular.Size = new System.Drawing.Size(202, 84);
            this.listBoxAltKonular.TabIndex = 10;
            this.listBoxAltKonular.ValueMember = "AltKonuAd";
         
            // 
            // altKonusBindingSource
            // 
            this.altKonusBindingSource.DataMember = "AltKonus";
            this.altKonusBindingSource.DataSource = this.nodeCodeDbDataSet;
            // 
            // nodeCodeDbDataSet
            // 
            this.nodeCodeDbDataSet.DataSetName = "NodeCodeDbDataSet";
            this.nodeCodeDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(77, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alt Konular:";
            // 
            // cbxDersler
            // 
            this.cbxDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDersler.FormattingEnabled = true;
            this.cbxDersler.Items.AddRange(new object[] {
            "Yapısal Programlama",
            "Modüler Programlama",
            "Nesne Tabanlı Programlama",
            "Olay Temelli Programlama"});
            this.cbxDersler.Location = new System.Drawing.Point(173, 151);
            this.cbxDersler.Name = "cbxDersler";
            this.cbxDersler.Size = new System.Drawing.Size(203, 24);
            this.cbxDersler.TabIndex = 8;
            this.cbxDersler.ValueMemberChanged += new System.EventHandler(this.cbxDersler_ValueMemberChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(118, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Konu:";
            // 
            // dgvKodNotlar
            // 
            this.dgvKodNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKodNotlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.dgvKodNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKodNotlar.Location = new System.Drawing.Point(30, 525);
            this.dgvKodNotlar.Name = "dgvKodNotlar";
            this.dgvKodNotlar.RowHeadersWidth = 51;
            this.dgvKodNotlar.RowTemplate.Height = 24;
            this.dgvKodNotlar.Size = new System.Drawing.Size(740, 119);
            this.dgvKodNotlar.TabIndex = 6;
            this.dgvKodNotlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKodNotlar_CellClick);
            // 
            // cbxKonular
            // 
            this.cbxKonular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxKonular.FormattingEnabled = true;
            this.cbxKonular.Items.AddRange(new object[] {
            "Yapısal Programlama",
            "Modüler Programlama",
            "Nesne Tabanlı Programlama",
            "Olay Temelli Programlama"});
            this.cbxKonular.Location = new System.Drawing.Point(173, 181);
            this.cbxKonular.Name = "cbxKonular";
            this.cbxKonular.Size = new System.Drawing.Size(203, 24);
            this.cbxKonular.TabIndex = 5;
            // 
            // txtAltKonu
            // 
            this.txtAltKonu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAltKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAltKonu.Location = new System.Drawing.Point(173, 123);
            this.txtAltKonu.Name = "txtAltKonu";
            this.txtAltKonu.Size = new System.Drawing.Size(204, 22);
            this.txtAltKonu.TabIndex = 4;
            // 
            // txtAltKonuID
            // 
            this.txtAltKonuID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAltKonuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAltKonuID.Location = new System.Drawing.Point(173, 95);
            this.txtAltKonuID.Name = "txtAltKonuID";
            this.txtAltKonuID.Size = new System.Drawing.Size(100, 22);
            this.txtAltKonuID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(122, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(95, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alt Konu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(138, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // altKonusTableAdapter
            // 
            this.altKonusTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKodNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 825);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKodNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKodNotlar";
            this.Load += new System.EventHandler(this.FrmKodNotlar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuKucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuBuyut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrnekKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altKonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeCodeDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btnMenuKucult;
        private System.Windows.Forms.PictureBox btnMenuBuyut;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKodNotlar;
        private System.Windows.Forms.ComboBox cbxKonular;
        private System.Windows.Forms.TextBox txtAltKonu;
        private System.Windows.Forms.TextBox txtAltKonuID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDersler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxAltKonular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxOrnekKod;
        private System.Windows.Forms.TextBox txtDetay;
        private System.Windows.Forms.TextBox txtSozDizimi;
        private System.Windows.Forms.TextBox txtKullanimAlani;
        private System.Windows.Forms.Button btnFotoSil;
        private System.Windows.Forms.Button btnFotoEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NodeCodeDbDataSet nodeCodeDbDataSet;
        private System.Windows.Forms.BindingSource altKonusBindingSource;
        private NodeCodeDbDataSetTableAdapters.AltKonusTableAdapter altKonusTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}