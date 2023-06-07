using Newtonsoft.Json;
using Postgrest.Attributes;
using Postgrest.Models;
using System;
using ColumnAttribute = Postgrest.Attributes.ColumnAttribute;
using TableAttribute = Postgrest.Attributes.TableAttribute;

namespace WindowsFormsApp1.Class
{
    [Table("cages")]
    class Cages : BaseModel
    {
        [PrimaryKey("id", true)]
        public int Id { get; set; }

        [Column("pet_id", nullValueHandling: NullValueHandling.Ignore)]
        public Guid? Pet_id { get; set; }

        [Column("pet_type_id", nullValueHandling: NullValueHandling.Ignore)]
        public Guid? Pet_type_id { get; set; }

        [Column("Empty")]
        public bool empty { get; set; }
    }
}