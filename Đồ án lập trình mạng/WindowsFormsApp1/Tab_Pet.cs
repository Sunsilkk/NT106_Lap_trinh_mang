using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;
using WindowsFormsApp1;

using System.IO;


namespace Pet_Management
{
    public partial class Tab_Pet : SupabaseControl
    {
        private List<Pet> PetList;
        private List<pet_types> Pet_TypesList;
        private List<Customers> CusList;

        public Tab_Pet(SupabaseManager manager) : base(manager)
        {
            InitializeComponent();
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

        public override async Task ClientRefresh()
        {
            dgv_PET.Rows.Clear();

            PetList = await GetPet();
            Pet_TypesList = await GetPetTypeList();
            CusList = await GetCus();
            tb_age.Text = string.Empty;
            tb_name.Text = string.Empty;
            cb_Cus.Items.Clear();
            cb_Cus.SelectedIndex = -1;
            cb_type.Items.Clear();
            cb_type.SelectedIndex = -1;
            // pb_petimage.Image = null;

            try
            {
                foreach (var cus in CusList)
                {
                    cb_Cus.Items.Add(cus.Name);
                }

                foreach (var pet in Pet_TypesList)
                {
                    cb_type.Items.Add(pet.Type);
                }

                foreach (var pet in PetList)
                {
                    dgv_PET.Rows.Add(pet.Id, pet.Name_Pet);
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }

        private async void Tab_Pet_Load(object? sender, EventArgs e)
        {
            await ClientRefresh();
        }

        private async void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != null && tb_age.Text != null && cb_Cus.SelectedItem != null && cb_type.SelectedItem != null)
            {
                var petlist = Pet_TypesList.FirstOrDefault(t => t.Type == cb_type.SelectedItem);
                var cuslist = CusList.FirstOrDefault(t => t.Name == cb_Cus.SelectedItem);
                //byte[] imageBytes = File.ReadAllBytes(imagePath);
                //string base64Image = Convert.ToBase64String(imageBytes);
                //JObject imageObject = new JObject
                //{
                //    { "data", base64Image },
                //    { "mime_type", "image/jpeg" }
                //};

                Pet newPet = new Pet
                {
                    Id = Guid.NewGuid(),
                    Custommer_id = cuslist.Id,
                    Type_id = petlist.Id,
                    Age = Int32.Parse(tb_age.Text),
                    Created_at = DateTimeOffset.Now,
                    Name_Pet = tb_name.Text,
                    //  Pet_image = imageObject.ToString(),
                };

                await supabase.From<Pet>().Insert(newPet);
                await ClientRefresh();
            }
        }

        private void tb_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private async void dgv_PET_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRowIndex = dgv_PET.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_PET.Rows[selectedRowIndex];
                string columnValue = selectedRow.Cells["NAME_P"].Value.ToString();
                var result = MessageBox.Show("Ban co chac chan muon xoa", "Thong bao", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    await supabase.From<Pet>().Where(x => x.Name_Pet == columnValue).Delete();
                    MessageBox.Show("Xoa thu cung thanh cong");
                    txt_age_ht.Text = string.Empty;
                    txt_name_ht.Text = string.Empty;
                    txt_type_ht.Text = string.Empty;
                    txt_cus_ht.Text = string.Empty;
                    txt_ID_HT.Text = string.Empty;
                    pb_petimage_ht.Image = null;
                    await ClientRefresh();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "loi");
            }
        }

        string imagePath;
        private void bt_selectimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png|All Files (*.*)|*.*";
            opf.Title = "Select an Image";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                imagePath = opf.FileName;
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Bitmap image = new Bitmap(ms);
                    Image resized_Image = ResizeImage(image, pb_petimage.Width, pb_petimage.Height);
                    pb_petimage.Image = resized_Image;
                }

            }

        }
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resized_Image = new Bitmap(width, height);
            using (Graphics gp = Graphics.FromImage(resized_Image))
            {
                gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gp.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gp.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gp.DrawImage(image, 0, 0, width, height);
            }

            return resized_Image;
        }

        private void dgv_PET_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pb_petimage_ht.Image = null;
            DataGridViewRow selectedRow = dgv_PET.Rows[e.RowIndex];
            if (selectedRow.Cells["id"].Value != null)
            {
                string getid = selectedRow.Cells["ID"].Value.ToString();
                txt_ID_HT.Text = getid;
                txt_name_ht.Text = selectedRow.Cells["NAME_P"].Value.ToString();
                var search_pet = PetList.FirstOrDefault(pet => pet.Id == Guid.Parse(getid));
                var type = Pet_TypesList.FirstOrDefault(t => t.Id == search_pet.Type_id);
                txt_type_ht.Text = type.Type;
                var cus_id = CusList.FirstOrDefault(t => t.Id == search_pet.Custommer_id);
                txt_cus_ht.Text = cus_id.Name;
                txt_age_ht.Text = search_pet.Age.ToString();
                //if (search_pet.Pet_image != null)
                //{
                //    display_image(search_pet);
                //}
                //else
                //{
                //    pb_petimage_ht.SizeMode = PictureBoxSizeMode.Normal;
                //    pb_petimage_ht.Text = "No Image";
                //}
            }
        }
        private void display_image(Pet pet)
        {
            //string image_j = pet.Pet_image.ToString();
            //JObject image_object = JObject.Parse(image_j);

            //string base64Image = image_object["data"].ToString();
            //string mimeType = image_object["mime_type"].ToString();
            //byte[] imageBytes = Convert.FromBase64String(base64Image);
            //using (MemoryStream ms = new MemoryStream(imageBytes))
            //{
            //    Image image = Image.FromStream(ms);
            //    Image resized_image = ResizeImage(image, pb_petimage_ht.Width, pb_petimage_ht.Height);
            //    pb_petimage_ht.Image = resized_image;
            //}
        }
    }
}