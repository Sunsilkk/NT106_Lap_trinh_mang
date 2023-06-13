using WindowsFormsApp1.Class;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using System.Linq;
using System.ComponentModel;

namespace Pet_Management
{
    public partial class Cage : SupabaseControl
    {
        private List<Pet> PetList;
        private List<pet_types> Pet_TypesList;
        private List<Cages> CagesList;

        public Cage(SupabaseManager manager) : base(manager)
        {
            InitializeComponent();
        }

        private async Task<List<Cages>> Getcage()
        {
            var result = await supabase.From<Cages>().Get();
            var cages = result.Models;
            return cages;
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
        public override async Task ClientRefresh()
        {
            dgv_Cages.Rows.Clear();
            CagesList = await Getcage();
            PetList = await GetPet();
            Pet_TypesList = await GetPetTypeList();
            try
            {
                foreach (var cage in CagesList)
                {
                    var existingPet = PetList.FirstOrDefault(t => t.Id == cage.Pet_id);
                    var existingPetList = Pet_TypesList.FirstOrDefault(t => t.Id == cage.Pet_type_id);
                    string name_pet = string.Empty, name_pet_type = string.Empty;
                    if (existingPet != null) name_pet = existingPet.Name_Pet.ToString();
                    if (existingPetList != null) name_pet_type = existingPetList.Type;
                    dgv_Cages.Rows.Add(cage.Id, name_pet, name_pet_type, cage.empty);
                }
            }
            catch (Exception ex) { }
            try
            {
                cb_PetName.Items.Clear();
                foreach (var pet in PetList)
                {
                    cb_PetName.Items.Add(pet.Name_Pet);
                }
            }
            catch (Exception ex) { }
            SortDataGridViewByID();
        }

        private void SortDataGridViewByID()
        {
            dgv_Cages.Sort(dgv_Cages.Columns["ID"], ListSortDirection.Ascending);
        }
        private async void Cage_Load(object sender, EventArgs e)
        {
            await ClientRefresh();
        }

        private void dgv_Cages_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Cages.Rows[e.RowIndex];
                string cageId = selectedRow.Cells["ID"].Value.ToString();
                string petName = selectedRow.Cells["PET_ID"].Value.ToString();
                string petType = selectedRow.Cells["PET_TYPE_ID"].Value.ToString();
                bool isEmpty = (bool)selectedRow.Cells["EMPTY"].Value;

                tb_petType.Text = petType;
                checkEmpty.Checked = isEmpty;
                cb_PetName.SelectedItem = petName;
            }
        }
        private async void bt_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Cages.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dgv_Cages.CurrentRow;
                if (checkEmpty.Checked)
                {
                    selectedRow.Cells["PET_ID"].Value = cb_PetName.SelectedItem;
                    selectedRow.Cells["PET_TYPE_ID"].Value = tb_petType.Text;
                    selectedRow.Cells["EMPTY"].Value = true;
                }
                else
                {
                    selectedRow.Cells["PET_ID"].Value = null;
                    selectedRow.Cells["PET_TYPE_ID"].Value = null;
                    selectedRow.Cells["EMPTY"].Value = false;
                }
                try
                {
                    var cageId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    var update = await supabase.From<Cages>().Where(x => x.Id == cageId).Single();

                    update.empty = checkEmpty.Checked;
                    if (checkEmpty.Checked)
                    {
                        var existingPet = PetList.FirstOrDefault(t => t.Name_Pet.ToString() == selectedRow.Cells["PET_ID"].Value);
                        if (existingPet != null)
                        {
                            update.Pet_id = existingPet.Id;
                            update.Pet_type_id = existingPet.Type_id;
                        }
                    }
                    else
                    {
                        update.Pet_id = null;
                        update.Pet_type_id = null;
                    }
                    // Create a new instance of Cages with the fields you want to update
                    var updatedCage = new Cages()
                    {
                        Id = update.Id,
                        Pet_id = update.Pet_id,
                        Pet_type_id = update.Pet_type_id,
                        empty = update.empty
                    };

                    // Use the new instance in the Update method
                    await supabase.From<Cages>().Update(updatedCage);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                await ClientRefresh();
            }
        }

        private void cb_PetName_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedPetName = cb_PetName.SelectedItem.ToString();
            var pet = PetList.FirstOrDefault(p => p.Name_Pet == selectedPetName);
            var pettype = Pet_TypesList.FirstOrDefault(t => t.Id == pet.Type_id);
            if (pettype != null)
            {
                tb_petType.Text = pettype.Type;
            }
            else
            {
                tb_petType.Text = string.Empty;
            }
        }
    }
}