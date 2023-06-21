using Postgrest.Models;
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

        public SupabaseControl()
        {
            InitializeComponent();
            Manager = new();
        }

        public virtual Task ClientRefresh()
        {
            return Task.CompletedTask;
        }

        public async Task<List<T>> Get<T>() where T : BaseModel, new()
        {
            var result = await Manager.Client.From<T>().Get();
            var transactions = result.Models;
            return transactions;
        }
    }
}
