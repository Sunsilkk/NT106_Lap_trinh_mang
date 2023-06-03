using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    [Table("transactions")]
    class Transactions : BaseModel
    {

        [PrimaryKey("id")]
        public Guid Id { get; set; }
        [PrimaryKey("customer_id")]
        public Guid Customer_id { get; set; }
        [PrimaryKey("product_id")]
        public Guid Product_id { get; set; }
        [PrimaryKey("cashier_id")]
        public Guid Cashier_id { get; set; }
    }
}
