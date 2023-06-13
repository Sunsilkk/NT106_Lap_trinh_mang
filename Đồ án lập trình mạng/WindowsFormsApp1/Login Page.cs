using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            button1.ForeColor = Color.FromArgb(236, 176, 58);
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
    }
}
