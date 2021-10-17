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


        //Метод снятия со счета
        public bool Withdraw(int sum)
        {
            if(Balance < sum )
            {
                return false;
            }
            else
            {
                Balance -= sum;
                return true;
            }
        }


        //Метод пополнения счета
        public bool TopUpAnAccount(int sum)
        {
            Balance += sum;
            return true;
        }
    }
}
