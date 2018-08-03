using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperation.Models
{
    public class Transaction
    {
        public string AcNumber { get; set; }
        public double Balance { get; set; }
        public int depositNum = 1;
        public int withdrawNum = 2;
    }

}
