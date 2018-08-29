using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        ProductDal _prodcDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }
      

        private void GetProductList()
        {
            dgwProducts.DataSource = _prodcDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _prodcDal.Add(new Product()
            {
                Name = txtName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitePrice.Text),
                StockAmount = Convert.ToInt32(txtStockAmount.Text)
            });
            GetProductList();
            MessageBox.Show("Products added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _prodcDal.Update(new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = txtNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(txtUnitePriceUpdate.Text),
                StockAmount = Convert.ToInt32(txtStockAmountUpdate.Text)
            });
            GetProductList();
            MessageBox.Show("Products updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitePriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _prodcDal.Delete(new Product() { Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value) });
            GetProductList();
            MessageBox.Show("Products removed!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProductList();
        }
    }
}
