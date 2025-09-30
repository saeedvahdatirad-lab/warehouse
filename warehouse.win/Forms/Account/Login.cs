using warehouse.win.Forms.Infrastucture;

namespace warehouse.win.Forms
{
    public partial class Login : MainForm
    {

        private readonly string _username = "admin";
        private readonly string _password = "123";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidaeBoxes();
           
            string username = txtUserName.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();

            if (_username == username && _password == password)
            {
                MessageBox.Show("خوش گلدیز");
            }
            else
            {
                MessageBox.Show("نام کاربری و کلمه عبور اشتباه است");
                txtPassword.Text = "";
            }
        }

        private void ValidaeBoxes()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("وارد کردن نام کاربری الزامی است");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("وارد کردن پسورد الزامی است");
                return;
            } 
        }
    }
}
