using NoteCode.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (NoteCodeDbContext dbContext=new NoteCodeDbContext())
            //{
            //    dbContext.Database.Create();
            //}
            //MessageBox.Show("database created");

            panelMenu.Width = 57;

        }

        private void btnFrmKodnot_Click(object sender, EventArgs e)
        {
            FrmKodNotlar frmKodNotlar = new FrmKodNotlar();
            frmKodNotlar.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmKonular frmKonular = new FrmKonular();
            frmKonular.Show();
            
        }

        private void btnMenuBuyut_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 150;
            btnMenuKucult.Visible = true;
            btnMenuBuyut.Visible = false;
        }

        private void btnMenuKucult_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 57;
            btnMenuBuyut.Visible = true;
            btnMenuKucult.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
