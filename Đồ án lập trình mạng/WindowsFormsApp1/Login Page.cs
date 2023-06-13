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
            textBox1.Text = "duongttt8@gmail.com";
            textBox2.Text = "SunsilkSunshine1708";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
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
        }
    }
}
