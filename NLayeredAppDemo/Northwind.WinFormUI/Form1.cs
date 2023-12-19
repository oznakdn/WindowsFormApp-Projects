using Northwind.BusinessLogic.Abstract;
using Northwind.BusinessLogic.Concrete;
using Northwind.BusinessLogic.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Kategoriye göre ara comboBox da listelenmesi için
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";

            // Kaydet işlemlerindeki comboBox da listelenmesi için
            cbxKategori.DataSource = _categoryService.GetAll();
            cbxKategori.DisplayMember = "CategoryName";
            cbxKategori.ValueMember = "CategoryID";

            // Güncelle işlemlerindeki comboBox da listelenmesi için
            cbxUpdateKategori.DataSource = _categoryService.GetAll();
            cbxUpdateKategori.DisplayMember = "CategoryName";
            cbxUpdateKategori.ValueMember = "CategoryID";


        }

        private void LoadProducts()
        {
            dgvProduct.DataSource = _productService.GetAll();
        }

        // Kategoriye göre arama
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource = _productService.GetProductByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        // Ürün adına göre arama
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text))
            {
                dgvProduct.DataSource = _productService.GetByProductName(txtProductName.Text);
            }
            else LoadProducts();
        }

        // Ürün ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {
                    CategoryID = Convert.ToInt32(cbxKategori.SelectedValue),
                    ProductName = txtUrunAd.Text,
                    QuantityPerUnit = txtBirimAdet.Text,
                    UnitPrice = Convert.ToDecimal(txtFiyat.Text),
                    UnitsInStock = Convert.ToInt16(txtStokAdet.Text)

                });
                MessageBox.Show("Ürün Eklendi");
                LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Ürün Güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product()
            {
                ProductID = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value),
                ProductName = txtUpdateUrun.Text,
                CategoryID = Convert.ToInt32(cbxUpdateKategori.SelectedValue),
                UnitPrice = Convert.ToDecimal(txtUpdateFiyat.Text),
                QuantityPerUnit = txtUpdateBirimAdet.Text,
                UnitsInStock = Convert.ToInt16(txtUpdateStokAdet.Text)
            });
            MessageBox.Show("Ürün Güncellendi");
            LoadProducts();

        }

        // Verilerin datagridview den textlere aktarılması
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvProduct.CurrentRow;
            txtUpdateUrun.Text = row.Cells[1].Value.ToString();
            cbxUpdateKategori.SelectedValue = row.Cells[2].Value;
            txtUpdateFiyat.Text = row.Cells[3].Value.ToString();
            txtUpdateBirimAdet.Text = row.Cells[4].Value.ToString();
            txtUpdateStokAdet.Text = row.Cells[5].Value.ToString();

        }

        // Ürün Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            // Datagridview alanı null değil ise (kayıt seçilmişse)
            if (dgvProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductID = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi");
                    LoadProducts();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}
