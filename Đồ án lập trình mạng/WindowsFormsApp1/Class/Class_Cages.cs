using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumnAttribute = Postgrest.Attributes.ColumnAttribute;
using TableAttribute = Postgrest.Attributes.TableAttribute;

namespace WindowsFormsApp1.Class
{
    [Table("cages")]
    class Cages : BaseModel
    {
        [PrimaryKey("id", true)]
        public int Id { get; set; }

        [Column("pet_id")]
        public Guid Pet_id { get; set; }

        [Column("pet_type_id")]
        public Guid Pet_type_id { get; set; }


        [Column("Empty")]
        public bool empty { get; set; }
    }
}