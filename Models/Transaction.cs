using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Models
{
   public class Transaction
    {
        public string myName = "john";
            public static string myStaticName = "Static John";
        public Transaction()
        {
            
        }

        public int addPayment()
        {
            int a =20, b =30;
            return a + b;
        }
        public int PaymentId { get; set; }
        public int UserID { get; set; }
        public double Payment_amount { get; set; }
        public UsersList UserLists { get; set; }
    }
}
