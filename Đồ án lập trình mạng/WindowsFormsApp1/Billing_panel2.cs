using Postgrest;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Windows.Compatibility;
using static System.Windows.Forms.Design.AxImporter;

namespace WindowsFormsApp1
{
    public partial class Billing_panel2 : Form
    {
        private Supabase.Client supabase;
        private List<products> productList;
        private products currentProduct = new products();
        private List<Transactions> transactions;
        private Billing billing;

        public Billing_panel2()
        {
            transactions = new List<Transactions>();

            billing = new Billing
            {
                Id = Guid.NewGuid()
            };

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

        private async Task<List<products>> GetProducts()
        {
            var result = await supabase.From<products>().Get();
            var product = result.Models;
            return product;
        }

        private async void bt_Add_Product_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Qty.SelectedItem == null) return;
                if (cb_Select.SelectedItem == null) return;

                var order = dgv_Billing.RowCount;

                var typeNameResult = await supabase
                    .From<product_types>()
                    .Select("type")
                    .Filter("id", Constants.Operator.Equals, currentProduct.Type_id)
                    .Get();

                var petTypeNameResult = await supabase
                    .From<pet_types>()
                    .Select("type")
                    .Filter("id", Constants.Operator.Equals, currentProduct.Pet_type_id)
                    .Get();

                var typeName = typeNameResult.Model.Type;
                var petTypeName = petTypeNameResult.Model.Type;

                dgv_Billing.Rows.Add(order, currentProduct.Name, typeName, petTypeName, cb_Qty.SelectedItem, currentProduct.Price);

                var qty = long.Parse(cb_Qty.SelectedItem.ToString());

                var currentTransaction = new Transactions
                {
                    Id = billing.Id,
                    ProductId = currentProduct.Id,
                    Quantity = qty,
                    Total = currentProduct.Price * qty,
                    CreatedAt = DateTime.Now,
                };

                billing.Total += currentTransaction.Total;

                lb_total.Text = billing.Total.ToString();

                transactions.Add(currentTransaction);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task LoadData()
        {
            productList = await GetProducts();
            foreach (var product in productList)
            {
                cb_Select.Items.Add(product.Name);
            }
        }

        private async void Billing_Load(object sender, EventArgs e)
        {
            lb_total.Text = "0";
            await LoadData();
        }

        private void cb_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Qty.Items.Clear();
            cb_Qty.SelectedIndex = -1;

            var productNames = new HashSet<string>(productList.Select(p => p.Name));

            if (productNames.Contains(cb_Select.SelectedItem.ToString()))
            {
                currentProduct = productList.FirstOrDefault(p => p.Name == cb_Select.SelectedItem.ToString());

                if (currentProduct != null)
                {
                    for (int stockCount = 1; stockCount <= currentProduct.Stock; stockCount++)
                    {
                        cb_Qty.Items.Add(stockCount);
                    }
                }
            }
        }

        private async void bt_Cash_Click(object sender, EventArgs e)
        {
            var qrBitmap = GenerateQRBitmap();

            billing.CustomerId = Guid.Parse("904ad093-36d7-4fce-ac7c-1f1b8e515dee");
            billing.CashierId = Guid.Parse(supabase.Auth.CurrentUser?.Id ?? "bf475bc9-f8dc-4cf0-978b-c2c25967e9e4");
            billing.CreatedAt = DateTime.Now;

            await supabase.From<Billing>().Insert(billing);

            await supabase.From<Transactions>().Insert(transactions);

            using var qrCodeForm = new QRCodeForm(qrBitmap);
            qrCodeForm.ShowDialog();
        }

        private Bitmap GenerateQRBitmap()
        {
            var momoQr = new MomoQR
            {
                PhoneNumber = "0355082441",
                Name = "Vo Thi Hoai Thanh",
                Email = "21520458@gm.uit.edu.vn",
                Total = int.Parse(lb_total.Text),
                Message = billing.Id.ToString(),
            };

            var encodingOptions = new EncodingOptions
            {
                Width = 250,
                Height = 250,
                Margin = 0,
                PureBarcode = false,
            };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            var barcodeWriter = new BarcodeWriter<Bitmap>
            {
                Renderer = new BitmapRenderer(),
                Options = encodingOptions,
                Format = BarcodeFormat.QR_CODE,
            };

            var bitmap = barcodeWriter.Write(momoQr.ToString());
            var logo = resizeImage(Properties.Resources.MoMo_Logo, 64, 64);
            var graphic = Graphics.FromImage(bitmap);
            graphic.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            return bitmap;
        }

        public Bitmap resizeImage(Image originalImage, int new_height, int new_width)
        {
            var new_image = new Bitmap(new_width, new_height);
            var graphic = Graphics.FromImage(new_image);
            graphic.InterpolationMode = InterpolationMode.High;
            graphic.DrawImage(originalImage, 0, 0, new_width, new_height);
            return new_image;
        }
    }

    public partial class QRCodeForm : Form
    {
        private PictureBox pictureBox;

        public QRCodeForm(Image qrCodeImage)
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(qrCodeImage.Width, qrCodeImage.Height);
            pictureBox.Image = qrCodeImage;
            Controls.Add(pictureBox);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // QRCodeForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "QRCodeForm";
            this.ResumeLayout(false);
        }
    }
}
