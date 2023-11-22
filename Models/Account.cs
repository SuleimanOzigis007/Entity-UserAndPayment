using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
    internal class Account
    {
        public int Id { get; set; }
        public int accountNumber { get; set; }
        public string? BVN { get; set; }
        public string? accountName { get; set; }
        
        public int phoneNumber { get; set; } 
       
    }
}
