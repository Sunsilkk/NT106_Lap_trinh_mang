using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsFormsApp1;
using WindowsFormsApp1.Class;

namespace Pet_Management
{
    public partial class Home : SupabaseControl
    {
        private List<pet_types> Pet_TypesList = null!;
        private List<Cages> CagesList = null!;
        private List<(string, string, int)> petList = null!;

        public Home(SupabaseManager manager) : base(manager)
        {
            InitializeComponent();
        }

        public override async Task ClientRefresh()
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

        public async void Home_Load(object? sender, EventArgs e)
        {
            await ClientRefresh();
        }
    }
}