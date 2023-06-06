using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Transactions;

namespace Pet_Management
{
    public partial class Tab_Pet : UserControl
    {
        Supabase.Client supabase;
        private List<Pet> PetList;
        private List<pet_types> Pet_TypesList;
        private List<Customers> CusList;
        public Tab_Pet()
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
        private async Task<List<Pet>> GetPet()
        {
            var result = await supabase.From<Pet>().Get();
            var Pet_p = result.Models;
            return Pet_p;
        }
        private async Task<List<pet_types>> GetPetTypeList()
        {
            var result = await supabase.From<pet_types>().Get();
            var Pet_t = result.Models;
            return Pet_t;
        }
        private async Task<List<Customers>> GetCus()
        {
            var result = await supabase.From<Customers>().Get();
            var Cuss = result.Models;
            return Cuss;
        }
        private async Task LoadData()
        {
            dgv_PET.Rows.Clear();

            PetList = await GetPet();
            Pet_TypesList = await GetPetTypeList();
            CusList = await GetCus();
            try
            {
                foreach (var cus in CusList)
                { cb_Cus.Items.Add(cus.Name); }
                foreach (var pet in Pet_TypesList)
                {
                    { cb_type.Items.Add(pet.Type); }

                }
                foreach (var pet in PetList)
                {

                    var type = Pet_TypesList.FirstOrDefault(t => t.Id == pet.Type_id);
                    var cus_id = CusList.FirstOrDefault(t => t.Id == pet.Custommer_id);
                    dgv_PET.Rows.Add(pet.Id, pet.Name_Pet, type.Type, cus_id.Name, pet.Age);
                }
            }



            catch (Exception ex) { }


        }
        private void Tab_Pet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != null && tb_age.Text != null && cb_Cus.SelectedItem != null && cb_type.SelectedItem != null)
            {
                var petlist = Pet_TypesList.FirstOrDefault(t => t.Type == cb_type.SelectedItem);
                var cuslist = CusList.FirstOrDefault(t => t.Name == cb_Cus.SelectedItem);
                Pet newPet = new Pet
                {
                    Id = Guid.NewGuid(),
                    Custommer_id = cuslist.Id,
                    Type_id = petlist.Id,
                    Age = Int32.Parse(tb_age.Text),
                    Created_at = DateTimeOffset.Now,
                    Name_Pet = tb_name.Text,
                };
                await supabase.From<Pet>().Insert(newPet);
                LoadData();
            }
        }

        private void tb_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
