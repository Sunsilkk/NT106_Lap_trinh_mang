using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    [Table("cages")]
    class Cages : BaseModel
    {
        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("pet_type_id")]
        public string pettypeID { get; set; }

        
    }
}
