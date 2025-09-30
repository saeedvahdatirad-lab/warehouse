using warehouse.win.Forms.Infrastucture;
using warehouse.win.Models.Product;

namespace warehouse.win.Forms
{
    public partial class AddNewProduct : MainForm
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            var x = new AddNewProductModel();
            x.ProductName = "گچ";
        }
    }
}

