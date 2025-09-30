using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse.win.Forms.Infrastucture
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
             InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "نرم افزار انبار داری سعید و شرکا";
        }
    }
}
