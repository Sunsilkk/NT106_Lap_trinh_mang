using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Management
{
    public partial class SupabaseControl : UserControl
    {
        public SupabaseManager Manager;

        protected Supabase.Client supabase => Manager.Client;

        public SupabaseControl(SupabaseManager manager)
        {
            InitializeComponent();
            Manager = manager;
        }

        public virtual Task ClientRefresh()
        {
            return Task.CompletedTask;
        }
    }
}
