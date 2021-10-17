using OOP_DZ2;
using System;
using static OOP_DZ2.BankAccount;

namespace DZ2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBankAccounts = new BankAccount();
            newBankAccounts.AccountNumber = 45;
            newBankAccounts.Balance = 100_000;

            //Выводим данные о банковском счете
            Print(newBankAccounts.AccountNumber,
                  newBankAccounts.Balance,
                  BankAccountType.calculated.ToString());


            //Вызываем метод снятия со счета и выводим данные о счете на экран
            if(newBankAccounts.Withdraw(50_000))
            {
                Console.WriteLine("Операция снятия со счета выполнена успешно");
                
                Print(newBankAccounts.AccountNumber,
                  newBankAccounts.Balance,
                  BankAccountType.calculated.ToString());
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете");
            }


            //Вызываем метод пополнения счета и выводим данные о счете
            if (newBankAccounts.TopUpAnAccount(100_000))
            {
                Console.WriteLine("Операция пополнения счета выполнена успешно");

                Print(newBankAccounts.AccountNumber,
                  newBankAccounts.Balance,
                  BankAccountType.calculated.ToString());
            }
        }

        //Метод выводит данные банковского счета на экран
        static void Print(int accountNumber, int balance, string bankAccountType)
        {
            Console.WriteLine($"Номер счета: {accountNumber} \n" +
                              $"Баланс: {balance} \n" +
                              $"Тип банковского счета: {bankAccountType} \n");
        }
    }
}
