using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DZ2
{
    class BankAccount
    {
        int _accountNumber;
        int _balance;

        public enum BankAccountType
        {
            current,
            calculated,
            debit,
            credit,
            deposit
        }

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
    }
}
