using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pet_Management
{
    public partial class Login_Page : Form
    {
        public SupabaseManager? SupabaseManager;

        public Login_Page()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Logging in...";
            button1.Enabled = false;
            try
            {
                SupabaseManager = new SupabaseManager();
                await SupabaseManager.Connect(textBox1.Text, textBox2.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {

            }
            button1.Text = "Submit";
            button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
