using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1;
using WindowsFormsApp1.Class;

namespace Pet_Management
{
    public partial class Home : UserControl
    {
        Supabase.Client supabase;
        private List<pet_types> Pet_TypesList;
        private List<Cages> CagesList;
        private List<(string, string, int)> petList;
       
        public Home()
        {
            InitializeComponent();
            InitializeSupabase();
        }
        //private async void InitializeSupabase()
        //{
        //    supabase = await SupabaseManager.GetSupabase();
        //}

        private async void InitializeSupabase()
        {
            var url = "https://hpvdlorgdoeaooibnffe.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImhwdmRsb3JnZG9lYW9vaWJuZmZlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODQ0MzA3ODMsImV4cCI6MjAwMDAwNjc4M30.toI_Vn6TKJFbM8YBT3qbYzLCiAfQtj9VHKw53qQNYOU";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client(url, key, options);

        }
        private async Task<List<(string, string, int)>> List_pet()
        {
            List<(string, string, int)> petList = new List<(string, string, int)>();
            foreach (var pet in Pet_TypesList)
            {
                petList.Add((pet.Id.ToString(), pet.Type, 0));
            }
            return petList;
        }
        private async Task<List<pet_types>> GetPetTypeList()
        {
            var result = await supabase.From<pet_types>().Get();
            var Pet_t = result.Models;
            return Pet_t;
        }
        private async Task<List<Cages>> Getcage()
        {
            var result = await supabase.From<Cages>().Get();
            var cages = result.Models;
            return cages;
        }
        private async Task<List<Transactions>> GetTrans()
        {
            var result = await supabase.From<Transactions>().Get();
            var trans = result.Models;
            return trans;
        }

        private async Task LoadData()
        {
            Pet_TypesList = await GetPetTypeList();
            CagesList = await Getcage();
            petList = await List_pet();
            var Trans = await GetTrans();
            long total = 0;
            try
            {
                foreach (var cage in CagesList)
                    if (cage.empty)
                    {
                        var existing = petList.FirstOrDefault(t => t.Item1 == cage.Pet_type_id.ToString());
                        if (existing != default)
                        {
                            var updatedTuple = (existing.Item1, existing.Item2, existing.Item3 + 1);
                            petList[petList.IndexOf(existing)] = updatedTuple;
                        }
                    }
                foreach (var item in Trans)
                {
                    total += item.Total;
                }
                l_total.Text = total.ToString();
            }
            catch (Exception ex) { }
        }
        public async void Home_Load(object sender, EventArgs e)
        {
            chart_pet.Size = new System.Drawing.Size(600, 600);
            await LoadData();
            chart_pet.ChartAreas[0].AxisY.Minimum = 0;
            chart_pet.ChartAreas[0].AxisY.Maximum = 10;
            chart_pet.ChartAreas[0].AxisY.Interval = 1;
            foreach (var item in petList)
            {
                chart_pet.Series["Series1"].Points.AddXY(item.Item2, item.Item3);
            }

        }
    }
}