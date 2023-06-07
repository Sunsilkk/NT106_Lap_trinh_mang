using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Table("pet_types")]
    class pet_types : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}
