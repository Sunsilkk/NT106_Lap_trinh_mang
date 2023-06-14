using System;
using System.Windows.Forms;

namespace Pet_Management
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar.Value = startPoint;
            if (progressBar.Value == 10)
            {
                progressBar.Value = 0;
                timer1.Stop();

                this.Hide();
            }
        }
        private void Landing_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}