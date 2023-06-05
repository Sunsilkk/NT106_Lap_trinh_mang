using WindowsFormsApp1.Class;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pet_Management
{
    public partial class Cage : UserControl
    {
        Supabase.Client supabase;
        public Cage()
        {
            InitializeComponent();
            InitializeSupabase();
        }
        private void InitializeSupabase()
        {
            var url = "https://hpvdlorgdoeaooibnffe.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImhwdmRsb3JnZG9lYW9vaWJuZmZlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODQ0MzA3ODMsImV4cCI6MjAwMDAwNjc4M30.toI_Vn6TKJFbM8YBT3qbYzLCiAfQtj9VHKw53qQNYOU";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client(url, key, options);

        }
        private async Task<List<Cages>> Getcage()
        {
            var result = await supabase.From<Cages>().Get();
            var cages = result.Models;
            return cages;
        }
        private async Task LoadData()
        {

            var cages = await Getcage();
            // dgv_Cages.Rows.Add(cages);
            try
            {
                foreach (var cage in cages)
                {
                    dgv_Cages.Rows.Add(cage.Id, cage.Pet_id, cage.Pet_type_id, cage.empty);
                }
            }
            catch (Exception ex) { }
        }
        private async void Cage_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}