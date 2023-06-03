using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bt_customer_Click(object sender, EventArgs e)
        {
             // show table customer + button add+ search
            checkform(panel6);           
            Customer_panel2 customerpanel2 = new Customer_panel2();
            customerpanel2.TopLevel = false;
           // customerpanel2.Dock = DockStyle.Fill;
            panel6.Controls.Add(customerpanel2);
            customerpanel2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            customerpanel2.Show();        
          
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void bn_products_Click(object sender, EventArgs e)
        {
            //panel6 hiện form datagirdview product +button add + search
            checkform(panel6);
            Product_panel2 productpanel2 = new Product_panel2();
            productpanel2.TopLevel = false;
            productpanel2.Dock = DockStyle.Fill;
            panel6.Controls.Add(productpanel2 );
            productpanel2.FormBorderStyle= System.Windows.Forms.FormBorderStyle.None;
            productpanel2.Show();
           
        }
        void checkform(Panel panel)
        {
            // kiểm tra xem trong panel có 1 form nào khác không nếu có đóng form hiện giờ để hiện form mới lên
            while (panel.Controls.Count > 0)
            {
                var currentControl = panel.Controls[0];
                if (currentControl is Form currentForm)
                {
                    currentForm.Close();
                }
                else
                {
                    panel.Controls.Remove(currentControl);
                }
            }
        }

        private void bt_Transactor_Click(object sender, EventArgs e)
        {
            checkform(panel6);
            Transaction_panel2 transactor_Panel2 = new Transaction_panel2();
            transactor_Panel2.TopLevel = false;
            transactor_Panel2.Dock = DockStyle.Fill;
            panel6.Controls.Add (transactor_Panel2);
            transactor_Panel2.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            transactor_Panel2.Show();
        }

        private void bt_Billing_Click(object sender, EventArgs e)
        {
            checkform (panel6);
            Billing billing_Panel2 = new Billing();
            billing_Panel2.TopLevel = false;
            billing_Panel2.Dock = DockStyle.Fill;
            panel6.Controls.Add (billing_Panel2);
            billing_Panel2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            billing_Panel2.Show();

        }
    }
}
