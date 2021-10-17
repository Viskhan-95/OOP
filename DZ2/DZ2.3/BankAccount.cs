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


        //Конструктор для заполнения поля баланс
        public BankAccount(int balance)
        {
            GetAccountNumber();
            _balance = balance;
        }


        //Конструктор для заполнения поля тип банковского счета
        public BankAccount(BankAccountType bankAccountType)
        {
            GetAccountNumber();
            bankAccountType = BankAccountType.debit;
        }


        //Конструктор для заполнения поля тип банковского счета и баланса
        public BankAccount(int balance, BankAccountType bankAccountType)
        {
            GetAccountNumber();
            _balance = balance;
            bankAccountType = BankAccountType.debit;
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
