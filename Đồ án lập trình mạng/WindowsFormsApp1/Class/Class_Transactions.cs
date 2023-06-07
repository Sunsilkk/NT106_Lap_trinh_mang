using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumnAttribute = Postgrest.Attributes.ColumnAttribute;
using TableAttribute = Postgrest.Attributes.TableAttribute;

namespace WindowsFormsApp1.Class
{
    [Table("transactions")]
    class Transactions : BaseModel
    {
        [PrimaryKey("id", true)]
        public Guid Id { get; set; }

        [Column("product_id")]
        public Guid ProductId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("total")]
        public long Total { get; set; }

        [Column("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
