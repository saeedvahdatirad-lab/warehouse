using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse.win.Models.Product;

namespace warehouse.win.Forms
{
    public partial class ProductsList : Form
    {
        public ProductsList()
        {
            InitializeComponent();
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;

            List<ProductListModel> products = new List<ProductListModel>()
    {
        new ProductListModel() { Id = 1, ProductCountUnit = "عدد", ProductName = "آجر" },
        new ProductListModel() { Id = 2, ProductCountUnit = "عدد", ProductName = "سیمان" },
        new ProductListModel() { Id = 3, ProductCountUnit = "عدد", ProductName = "گچ" }
    };

            dataGridView1.DataSource = products.ToList();
        }


        // dataGridView1.DataBindings.Add(products);
        //TODO saeid
        // توی صفحه باید این سه کالا که بالا تعریف شده توی جدول نمایش داده بشه


        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var f = new AddNewProduct();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
