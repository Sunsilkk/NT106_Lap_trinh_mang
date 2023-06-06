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

namespace WindowsFormsApp1
{
    public partial class Billing_panel2 : UserControl
    {
        private Supabase.Client supabase;
        private List<Products> productList;
        private Products currentProduct = new Products();
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

        private async Task<List<Products>> GetProducts()
        {
            var result = await supabase.From<Products>().Get();
            var product = result.Models;
            return product;
        }
        private void dgv_Billing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgv_Billing.Columns[e.ColumnIndex] is DataGridViewColumn && e.RowIndex < dgv_Billing.Rows.Count - 1)
                {
                    var result = MessageBox.Show("Xóa sản phẩm đã chọn?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var selectedRow = dgv_Billing.Rows[e.RowIndex];
                        var transactionToRemove = transactions.FirstOrDefault(t => t.ProductId == currentProduct.Id);
                        if (transactionToRemove != null)
                        {
                            transactions.Remove(transactionToRemove);
                            dgv_Billing.Rows.RemoveAt(e.RowIndex);
                            UpdateTotal();
                        }
                    }
                }
            }
        }
        private async void bt_Add_Product_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Qty.SelectedItem == null) return;
                if (cb_Select.SelectedItem == null) return;

                var qty = int.Parse(cb_Qty.SelectedItem.ToString());
                var existingTransaction = transactions.FirstOrDefault(t => t.ProductId == currentProduct.Id);

                if (existingTransaction != null)
                {
                    existingTransaction.Quantity += qty;
                    if (existingTransaction.Quantity > currentProduct.Stock)
                    {
                        existingTransaction.Quantity -= qty;
                        MessageBox.Show("Số lượng sản phẩm đã chọn vượt quá số lượng hiện có", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    existingTransaction.Total = currentProduct.Price * existingTransaction.Quantity;
                    UpdateRowQty(existingTransaction);

                }
                else
                {
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

                    dgv_Billing.Rows.Add(order, currentProduct.Name, typeName, petTypeName, qty, currentProduct.Price);

                    var currentTransaction = new Transactions
                    {
                        Id = billing.Id,
                        ProductId = currentProduct.Id,
                        Quantity = qty,
                        Total = currentProduct.Price * qty,
                        CreatedAt = DateTime.Now,
                    };

                    transactions.Add(currentTransaction);
                }

                UpdateTotal();

                cb_Qty.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateRowQty(Transactions transaction)
        {
            foreach (DataGridViewRow row in dgv_Billing.Rows)
            {
                var productId = row.Cells["dgv_Name"].Value.ToString();
                if (productId == cb_Select.SelectedItem)
                {
                    row.Cells["Qty"].Value = transaction.Quantity;
                    break;
                }
            }
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (var transaction in transactions)
            {
                total += transaction.Total;
            }
            lb_total.Text = total.ToString();
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



            using var qrCodeForm = new QRCodeForm(qrBitmap);
            var dialogResult = qrCodeForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (qrCodeForm.IsOKClicked)
                {
                    try
                    {
                        await supabase.From<Billing>().Insert(billing);
                        await supabase.From<Transactions>().Insert(transactions);
                        foreach (var transaction in transactions)
                        {
                            var update = await supabase
                            .From<Products>()
                            .Where(x => x.Id == transaction.ProductId)
                            .Single();
                            update.Stock -= transaction.Quantity;
                            await update.Update<Products>();
                        }
                        dgv_Billing.Rows.Clear();
                    }
                    catch (Exception ex) { }
                }
            }
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
            var logo = resizeImage(Pet_Management.Properties.Resources.MoMo_Logo, 64, 64);
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

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            lb_total.Text = "0";
            dgv_Billing.Rows.Clear();
            transactions.Clear();
            billing = null;
        }

        private void dgv_Billing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



    public partial class QRCodeForm : Form
    {
        private PictureBox pictureBox;
        private Button buttonOK;
        private Button buttonCancel;
        public bool IsOKClicked { get; private set; }
        public QRCodeForm(Image qrCodeImage)
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(qrCodeImage.Width, qrCodeImage.Height);
            pictureBox.Image = qrCodeImage;
            Controls.Add(pictureBox);

            buttonOK = new Button();
            buttonOK.Text = "OK";
            buttonOK.Location = new Point(50, qrCodeImage.Height + 10);
            buttonOK.Click += ButtonOK_Click;
            Controls.Add(buttonOK);

            buttonCancel = new Button();
            buttonCancel.Text = "Cancel";
            buttonCancel.Location = new Point(150, qrCodeImage.Height + 10);
            buttonCancel.Click += ButtonCancel_Click;
            Controls.Add(buttonCancel);
        }

        private void InitializeComponent()
        {

            this.SuspendLayout();
            // 
            // QRCodeForm
            // 
            this.ClientSize = new System.Drawing.Size(264, 300);
            this.Name = "QRCodeForm";
            this.ResumeLayout(false);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            IsOKClicked = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            IsOKClicked = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
