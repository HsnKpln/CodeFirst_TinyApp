using sql_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_HomeWork
{
    public enum Disc
    {
        False,
        True
    }
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        NorthwindContext _dbContext= new NorthwindContext();
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listeyiDoldurCategory();
            listeyiDoldurTedarikci();
            listeyiDoldurUrunler();
            cmbDiscounted.DataSource = Enum.GetNames(typeof(Disc));
        }
        
        private void listeyiDoldurCategory()
        {
            lstKategori.Items.Clear();
            foreach (Category item in _dbContext.Categories)
            {
                lstKategori.Items.Add(item);
            }
        }
        private void listeyiDoldurTedarikci()
        {
            lstTedarikci.Items.Clear();
            foreach (Supplier item in _dbContext.Suppliers)
            {
                lstTedarikci.Items.Add(item);
            }
        }
        private void listeyiDoldurUrunler()
        {
            lstUrunler.Items.Clear();
            foreach (Product item in _dbContext.Products)
            {
                lstUrunler.Items.Add(item);
            }
        }
        public void TemizleUrun()
        {
            lstKategori.SelectedIndex = -1;
            lstTedarikci.SelectedIndex = -1;
            lstUrunler.SelectedIndex = -1;
            txtUrunAdi.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            txtOrder.Text = "";
            txtLevel.Text = "";
            cmbDiscounted.SelectedIndex = -1;
        }
        Category _selectedCategory;
        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedIndex == -1) return;
            _selectedCategory=lstKategori.SelectedItem as Category;
        }
        Supplier _selectedSupplier;
        private void lstTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTedarikci.SelectedIndex == -1) return ;
            _selectedSupplier=lstTedarikci.SelectedItem as Supplier;
        }
        Product _selectedProduct;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstUrunler.SelectedIndex== -1) return ;
            _selectedProduct=lstUrunler.SelectedItem as Product;
            foreach (Category item in _dbContext.Categories)
            {
                if (item.CategoryId==_selectedProduct.CategoryId)
                {
                    _selectedCategory = item;
                    lstKategori.SelectedItem = _selectedCategory;
                }
            }
            foreach (Supplier item1 in _dbContext.Suppliers)
            {
                if (item1.SupplierId == _selectedProduct.SupplierId)
                {
                    _selectedSupplier = item1;
                    lstTedarikci.SelectedItem = _selectedSupplier;
                }
            }
            txtUrunAdi.Text = _selectedProduct.ProductName;
            txtQuantity.Text = _selectedProduct.QuantityPerUnit;
            txtPrice.Text = _selectedProduct.UnitPrice.ToString();
            txtStock.Text = _selectedProduct.UnitsInStock.ToString();
            txtOrder.Text = _selectedProduct.UnitsOnOrder.ToString();
            txtLevel.Text = _selectedProduct.ReorderLevel.ToString();
            cmbDiscounted.SelectedItem = Enum.GetName(typeof(Disc), _selectedProduct.Discontinued);
        }

        private void btnUrunlerKaydet_Click(object sender, EventArgs e)
        {
            if (lstTedarikci.SelectedIndex == -1) return;
            if (lstKategori.SelectedIndex == -1) return;
            Product newProduct = new Product();
            try
            {
                newProduct.Category = _selectedCategory;
                newProduct.Supplier = _selectedSupplier;
                newProduct.ProductName = txtUrunAdi.Text;
                newProduct.Discontinued = bool.Parse(cmbDiscounted.SelectedItem.ToString());
                newProduct.QuantityPerUnit = txtQuantity.Text;
                newProduct.ReorderLevel = short.Parse(txtLevel.Text);
                newProduct.UnitPrice = decimal.Parse(txtPrice.Text);
                newProduct.UnitsOnOrder = short.Parse(txtOrder.Text);
                newProduct.UnitsInStock = short.Parse(txtStock.Text);
                _dbContext.Products.Add(newProduct);
                _dbContext.SaveChanges();
                TemizleUrun();
                listeyiDoldurUrunler();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUrunlerGuncelle_Click(object sender, EventArgs e)
        {
            if (lstTedarikci.SelectedIndex == -1) return;
            if (lstKategori.SelectedIndex == -1) return;
            try
            {
                _selectedProduct.Category = _selectedCategory;
                _selectedProduct.Supplier = _selectedSupplier;
                _selectedProduct.ProductName = txtUrunAdi.Text;
                _selectedProduct.Discontinued = bool.Parse(cmbDiscounted.SelectedItem.ToString());
                _selectedProduct.QuantityPerUnit = txtQuantity.Text;
                _selectedProduct.ReorderLevel = short.Parse(txtOrder.Text);
                _selectedProduct.UnitPrice = decimal.Parse(txtPrice.Text);
                _selectedProduct.UnitsOnOrder = short.Parse(txtOrder.Text);
                _selectedProduct.UnitsInStock = short.Parse(txtStock.Text);
                _dbContext.SaveChanges();
                TemizleUrun();
                listeyiDoldurUrunler();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Bir Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUrunlerSil_Click(object sender, EventArgs e)
        {
            if (_selectedProduct is not null)
            {
                _dbContext.Products.Remove(_selectedProduct);
                _dbContext.SaveChanges();
                listeyiDoldurUrunler();
                TemizleUrun();
            }
        }

        private void btnUrunlerTemizle_Click(object sender, EventArgs e)
        {
            TemizleUrun();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            if (string.IsNullOrEmpty(txtAra.Text))
            {
                lstUrunler.DataSource = _dbContext.Products.ToList();
            }
            else
            {
                foreach (var item in _dbContext.Products)
                {
                    if (item.ProductName.ToUpper().Contains(txtAra.Text.ToUpper()))
                    {
                        products.Add(item);
                    }
                }
                lstUrunler.DataSource=products;
            }
        }
    }
}
