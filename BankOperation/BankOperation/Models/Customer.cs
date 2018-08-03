using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string AcNumber { get; set; }
        public DateTime OpeningDate { get; set; }
        public double balance;
    }

}
