using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.PrintAccount();
            bankAccount1 = new BankAccount(5000.00m, AccountType.CreditAccount);
            bankAccount1.PrintAccount();
            bankAccount1 = new BankAccount(6895544.87m);
            bankAccount1.PrintAccount();
            bankAccount1 = new BankAccount(AccountType.SavingAccount);
            bankAccount1.PrintAccount();

            Console.ReadKey();
        }
    }
}
