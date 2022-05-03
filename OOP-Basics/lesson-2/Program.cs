using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(5000.00m, AccountType.CreditAccount);
            bankAccount1.PrintAccount();
            bankAccount1.TransferToTheAccount(bankAccount1, 500.00m);

            Console.ReadKey();
        }
    }
}
