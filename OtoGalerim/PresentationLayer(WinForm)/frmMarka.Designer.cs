
namespace PresentationLayer_WinForm_
{
    partial class frmMarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarka));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.pictureBoxMarkaLogo = new System.Windows.Forms.PictureBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnFotoSil = new System.Windows.Forms.Button();
            this.btnFotoYukle = new System.Windows.Forms.Button();
            this.dataGridViewMarka = new System.Windows.Forms.DataGridView();
            this.MarkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaLogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serileri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarkaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarka)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.btnSatisYap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnSatisYap.Enabled = false;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYap.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnSatisYap.Location = new System.Drawing.Point(721, 24);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(227, 46);
            this.btnSatisYap.TabIndex = 28;
            this.btnSatisYap.Text = "SATIŞ YAP";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Markalar";
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
            // txtMarkaID
            // 
            this.txtMarkaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtMarkaID.Location = new System.Drawing.Point(97, 140);
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.Size = new System.Drawing.Size(65, 22);
            this.txtMarkaID.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label13.Location = new System.Drawing.Point(61, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(32, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka :";
            // 
            // txtMarka
            // 
            this.txtMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(96)))), ((int)(((byte)(129)))));
            this.txtMarka.Location = new System.Drawing.Point(97, 168);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(125, 22);
            this.txtMarka.TabIndex = 6;
            // 
            // pictureBoxMarkaLogo
            // 
            this.pictureBoxMarkaLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMarkaLogo.Location = new System.Drawing.Point(307, 106);
            this.pictureBoxMarkaLogo.Name = "pictureBoxMarkaLogo";
            this.pictureBoxMarkaLogo.Size = new System.Drawing.Size(117, 98);
            this.pictureBoxMarkaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMarkaLogo.TabIndex = 7;
            this.pictureBoxMarkaLogo.TabStop = false;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnYeni.Location = new System.Drawing.Point(419, 229);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(114, 30);
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
            this.btnKaydet.Location = new System.Drawing.Point(419, 265);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 30);
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
            this.btnSil.Location = new System.Drawing.Point(418, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 30);
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
            this.btnFotoSil.Location = new System.Drawing.Point(430, 157);
            this.btnFotoSil.Name = "btnFotoSil";
            this.btnFotoSil.Size = new System.Drawing.Size(102, 33);
            this.btnFotoSil.TabIndex = 26;
            this.btnFotoSil.Text = "Kaldır";
            this.btnFotoSil.UseVisualStyleBackColor = false;
            this.btnFotoSil.Click += new System.EventHandler(this.btnFotoSil_Click);
            // 
            // btnFotoYukle
            // 
            this.btnFotoYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(107)))));
            this.btnFotoYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoYukle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoYukle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.btnFotoYukle.Location = new System.Drawing.Point(430, 115);
            this.btnFotoYukle.Name = "btnFotoYukle";
            this.btnFotoYukle.Size = new System.Drawing.Size(102, 36);
            this.btnFotoYukle.TabIndex = 27;
            this.btnFotoYukle.Text = "Yükle";
            this.btnFotoYukle.UseVisualStyleBackColor = false;
            this.btnFotoYukle.Click += new System.EventHandler(this.btnFotoYukle_Click);
            // 
            // dataGridViewMarka
            // 
            this.dataGridViewMarka.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarka.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(113)))), ((int)(((byte)(149)))));
            this.dataGridViewMarka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarkaID,
            this.MarkaAd,
            this.MarkaLogo,
            this.Serileri});
            this.dataGridViewMarka.Location = new System.Drawing.Point(21, 229);
            this.dataGridViewMarka.Name = "dataGridViewMarka";
            this.dataGridViewMarka.RowHeadersWidth = 51;
            this.dataGridViewMarka.RowTemplate.Height = 24;
            this.dataGridViewMarka.Size = new System.Drawing.Size(392, 102);
            this.dataGridViewMarka.TabIndex = 28;
            this.dataGridViewMarka.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarka_CellClick);
            // 
            // MarkaID
            // 
            this.MarkaID.DataPropertyName = "MarkaID";
            this.MarkaID.HeaderText = "ID";
            this.MarkaID.MinimumWidth = 6;
            this.MarkaID.Name = "MarkaID";
            // 
            // MarkaAd
            // 
            this.MarkaAd.DataPropertyName = "MarkaAd";
            this.MarkaAd.HeaderText = "Marka";
            this.MarkaAd.MinimumWidth = 6;
            this.MarkaAd.Name = "MarkaAd";
            // 
            // MarkaLogo
            // 
            this.MarkaLogo.DataPropertyName = "MarkaLogo";
            this.MarkaLogo.HeaderText = "Logo";
            this.MarkaLogo.MinimumWidth = 6;
            this.MarkaLogo.Name = "MarkaLogo";
            // 
            // Serileri
            // 
            this.Serileri.DataPropertyName = "Serileri";
            this.Serileri.HeaderText = "Serileri";
            this.Serileri.MinimumWidth = 6;
            this.Serileri.Name = "Serileri";
            this.Serileri.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 355);
            this.Controls.Add(this.dataGridViewMarka);
            this.Controls.Add(this.btnFotoSil);
            this.Controls.Add(this.btnFotoYukle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBoxMarkaLogo);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarkaID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarka";
            this.Load += new System.EventHandler(this.frmMarka_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarkaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.PictureBox pictureBoxMarkaLogo;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnFotoSil;
        private System.Windows.Forms.Button btnFotoYukle;
        private System.Windows.Forms.DataGridView dataGridViewMarka;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serileri;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}