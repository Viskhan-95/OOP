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
        public bool Withdraw(BankAccountType bankAccountType, int sum)
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
        public bool TopUpAnAccount(BankAccountType bankAccountType, int sum)
        {
            Balance += sum;
            return true;
        }


        //Метод перевода средств
        public void Transfer(BankAccount bankAccount, int sumTranslate)
        {
            if(bankAccount.Withdraw(BankAccountType.debit, sumTranslate))
            {
                TopUpAnAccount(BankAccountType.credit, 1000);
                Console.WriteLine("Операция выполнена успешно");
            }
            else
            {
                Console.WriteLine("Недостаточно средств для выыполнения лпеоации");
            }

        }
    }
}
