using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    [Table("pets")]
    class Pet : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }
        [Column("customer_id")]
        public Guid customerID { get; set; }

        [Column("type_id")]
        public Guid typeID { get; set; }

        [Column("cage_id")]
        public int cageID { get; set; }

        [Column("age")]
        public int Age { get; set; }

        [Column("created_at")]
        public DateTimeOffset Created_at { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
