using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recap_Demo_3.Context;

namespace Recap_Demo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategory();
        }

        private void ListCategory()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxKategori.DataSource = context.Categories.ToList();
                cbxKategori.DisplayMember = "CategoryName";
                cbxKategori.ValueMember = "CategoryId";
            }
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.ToList();
                grdViewProducts.DataSource = result;
            }
        }
        private void ListProductsByName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

               if(!string.IsNullOrEmpty(key))
                grdViewProducts.DataSource = context.Products.Where(p => p.ProductName.Contains(key)).ToList();
            }
        }
        private void ListProductsByCategory(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                if (id != 0)
                    grdViewProducts.DataSource = context.Products.Where(p => p.CategoryId == id).ToList();

            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ListProductsByName(txtProductName.Text);
        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListProductsByCategory(cbxKategori.SelectedIndex);
        }
    }
}
