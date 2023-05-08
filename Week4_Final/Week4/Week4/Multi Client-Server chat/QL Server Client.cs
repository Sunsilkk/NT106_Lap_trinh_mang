using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Client_Server_chat
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void b_Server_Click(object sender, EventArgs e)
        {
            var newform = new  Server();
            newform.Show();
        }

        private void b_Client_Click(object sender, EventArgs e)
        {
            var newform = new Client();
            newform.Show();
        }
    }
}
