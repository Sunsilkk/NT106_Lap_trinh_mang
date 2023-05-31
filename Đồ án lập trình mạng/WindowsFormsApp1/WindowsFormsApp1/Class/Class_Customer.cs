
using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    [Table("customers")]
    class Customers : BaseModel
    {
        
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("phone")]
        public int Phone { get; set; }

       [Column("created_at")]
        public DateTimeOffset Created_at { get; set; }
    }
}
