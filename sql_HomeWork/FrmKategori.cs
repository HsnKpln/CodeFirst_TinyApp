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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
         NorthwindContext _dbContext = new NorthwindContext();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            listeyiDoldur();
        }
        private void listeyiDoldur()
        {
            lstKategoriler.Items.Clear();
            foreach (Category item in _dbContext.Categories)
            {
                lstKategoriler.Items.Add(item);
            }
            
        }
        private void Temizle()
        {
            txtKategoriAdi.Text = "";
            txtAciklamalar.Text = "";
        }
        private Category selectedCategory;
        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategoriler.SelectedIndex == -1) return;
            selectedCategory=lstKategoriler.SelectedItem as Category;
            txtKategoriAdi.Text = selectedCategory.CategoryName;
            txtAciklamalar.Text = selectedCategory.Description;

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category();
            try
            {
                newCategory.CategoryName = txtKategoriAdi.Text;
                newCategory.Description = txtAciklamalar.Text;
                _dbContext.Categories.Add(newCategory);
                _dbContext.SaveChanges();
                listeyiDoldur();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message,"Bir hata oluştu.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            selectedCategory.CategoryName=txtKategoriAdi.Text;
            selectedCategory.Description=txtAciklamalar.Text;
            _dbContext.SaveChanges();
            listeyiDoldur();
            Temizle();
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (selectedCategory == null) return;
            _dbContext.Categories.Remove(selectedCategory);
            _dbContext.SaveChanges();
            listeyiDoldur();
            Temizle();
        }
    }
}
