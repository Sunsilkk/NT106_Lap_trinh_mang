using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Supabase;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class HomeNV : Form
    {
        Supabase.Client supabase;

        public HomeNV()
        {
            InitializeComponent();
           
        }

        private async void HomeNV_Load(object sender, EventArgs e)
        {
            var url = "https://hpvdlorgdoeaooibnffe.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImhwdmRsb3JnZG9lYW9vaWJuZmZlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODQ0MzA3ODMsImV4cCI6MjAwMDAwNjc4M30.toI_Vn6TKJFbM8YBT3qbYzLCiAfQtj9VHKw53qQNYOU";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();

            var session = await supabase.Auth.SignIn("admin@test.com", "@admin123");



            //var result1 = await supabase.From<Cages>().Select("pettypeID = 'Dog', count(*)").Get();
            //var result1 = await supabase.From<Cages>().Select("pettypeID, count(*)").Eq("pettypeID", "Dog").Get();
            var response = await supabase
                .From("<Cages>")
                .Select("COUNT(*)")
                .Eq("pettypeID", "Dog")
                .Execute();
        }
    }
}
