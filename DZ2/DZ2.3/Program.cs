using OOP_DZ2;
using System;
using static OOP_DZ2.BankAccount;

namespace DZ2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBankAccounts = new BankAccount(500_000);
            
            var newBankAccounts2 = new BankAccount(BankAccountType.debit);
            
            var newBankAccounts3 = new BankAccount(600_000, BankAccountType.debit);

        }
    }
}
