using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_DZ2
{
    class BankAccount
    {
        static int _accountNumber;
        int _balance;

        public enum BankAccountType
        {
            current,
            calculated,
            debit,
            credit,
            deposit
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

        public int AccountNumber
        {
            get
            {
                GetAccountNumber();
                return _accountNumber;
            }
        }

        //Метод получения номера счета
        static void GetAccountNumber()
        {
            if (_accountNumber == 0)
            {
                Random rnd = new();
                _accountNumber = rnd.Next(1000);
            }
            else
            {
                _accountNumber++;
            }
        }
    }
}
