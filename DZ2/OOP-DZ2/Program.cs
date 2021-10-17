using System;
using static OOP_DZ2.BankAccount;

namespace OOP_DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBankAccounts = new BankAccount();
            newBankAccounts.AccountNumber = 45;
            newBankAccounts.Balance = 555_000;

            Print(newBankAccounts.AccountNumber,
                  newBankAccounts.Balance,
                  BankAccountType.deposit.ToString());
        }

        //Метод выводит данные на экран
        static void Print(int accountNumber, int balance, string bankAccountType)
        {
            Console.WriteLine($"Номер счета: {accountNumber} \n" + 
                              $"Баланс: {balance} \n" +
                              $"Тип банковского счета: {bankAccountType}");
        }
    }
}
