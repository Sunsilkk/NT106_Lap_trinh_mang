using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void bt_Add_Product_Click(object sender, EventArgs e)
        {

        }

        private void Billing_panel2_Load(object sender, EventArgs e)
        {
            lb_total.Text = "NULL";
        }
    }
}
