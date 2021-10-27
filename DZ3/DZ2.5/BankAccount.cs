using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DZ2
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public int Balance { get; set; }

        public enum BankAccountType
        {
            current,
            calculated,
            debit,
            credit,
            deposit
        }
    }
}
