using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Class
{
    class MomoQR
    {
        private const string _type = "transfer_myqr";

        public string? PhoneNumber { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Total { get; set; }
        public string? Message { get; set; }
        
        public override string ToString()
            => $"2|99|{PhoneNumber}|{Name}|{Email}|0|0|{Total}|{Message}|{_type}";
    }
}
