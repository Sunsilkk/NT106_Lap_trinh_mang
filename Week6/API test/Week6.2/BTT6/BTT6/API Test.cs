using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTT6
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void bt_Get_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos").ConfigureAwait(false);
                string responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                // Use BeginInvoke to update the UI on the main thread
                BeginInvoke((Action)(() =>
                {
                    ToDoList.Text = responseString;
                }));
            }
            catch (HttpRequestException ex)
            {
                // Use BeginInvoke to update the UI on the main thread
                BeginInvoke((Action)(() =>
                {
                    ToDoList.Text = ex.Message;
                }));
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            ToDoList.Text = null;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_exit_MouseMove(object sender, MouseEventArgs e)
        {
            bt_exit.BackColor = Color.DarkRed;
        }

        private void bt_exit_MouseLeave(object sender, EventArgs e)
        {
            bt_exit.BackColor = Color.IndianRed;
        }
    }
}
