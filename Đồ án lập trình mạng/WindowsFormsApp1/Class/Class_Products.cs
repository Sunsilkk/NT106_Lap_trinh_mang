
using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Table("products")]
    class Products : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("type_id")]
        public string? Type_id { get; set; }

        [Column("pet_type_id")]
        public string? Pet_type_id { get; set; }

        [Column("name")]
        public string? Name { get; set; }


        [Column("stock")]
        public long Stock { get; set; }

        [Column("price")]
        public long Price { get; set; }

        [Column("created_at")]
        public DateTimeOffset Created_at { get; set; }
    }
}
