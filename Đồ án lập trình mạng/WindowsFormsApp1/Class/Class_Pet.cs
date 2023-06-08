using Newtonsoft.Json;
using Postgrest.Attributes;
using Postgrest.Models;
using System;
using ColumnAttribute = Postgrest.Attributes.ColumnAttribute;
using TableAttribute = Postgrest.Attributes.TableAttribute;

namespace WindowsFormsApp1.Class
{
    [Table("pets")]
    class Pet: BaseModel
    {
        [PrimaryKey("id",true)]
        public Guid Id { get; set; }
        [Column("customer_id")]
        public Guid Custommer_id { get; set; }
        [Column("type_id")]
        public Guid Type_id { get; set; }
        [Column("age")]
        public int? Age { get; set; }
        [Column("created_at")]
        public DateTimeOffset Created_at { get; set; }

        [Column("name")]
        public string Name_Pet { get; set; }

        [Column("pet_image")]
        public string Pet_image { get; set; }
    }
}
