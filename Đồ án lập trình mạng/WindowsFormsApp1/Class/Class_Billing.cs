using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    [Table("billing")]
    class Billing : BaseModel
    {
        [PrimaryKey("id", true)]
        public Guid Id { get; set; }

        [Column("customer_id")]
        public Guid CustomerId { get; set; }

        [Column("cashier_id")]
        public Guid CashierId { get; set; }

        [Column("total")]
        public long Total { get; set; }

        [Column("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
