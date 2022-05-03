using System;


namespace lesson_2
{
    enum AccountType
    {
        DebitAccount, //дебетовый счет
        CreditAccount,//кредитный счет
        SavingAccount,//сберегательный счет
        Unknown       //неизвестный счет
    }

    class BankAccount
    {
        
        private static int _accountNumber;
        private decimal _balance;
        private AccountType _accountType;
        
        private static int CreateAccountNumber()
        {
            Random rnd = new Random();
            return _accountNumber = rnd.Next(10000, 99999); 
        }

        public BankAccount()
        {
            CreateAccountNumber();
            _balance = 0;
            _accountType = AccountType.Unknown;
        }

        public BankAccount(decimal _balance)
        {
            CreateAccountNumber();
            this._balance = _balance;
        }

        public BankAccount(AccountType _accountType)
        {
            CreateAccountNumber();
            this._accountType = _accountType;
        }

        public BankAccount(decimal _balance, AccountType _accountType)
        {
            CreateAccountNumber();
            this._balance = _balance;
            this._accountType = _accountType;
        }

        public void PrintAccount()
        {
            Console.WriteLine($"--------------------------\n" +
                              $"Номер счета: {_accountNumber}\n" +
                              $"Баланс: {_balance} $\n" +
                              $"Тип счета: {_accountType}\n" +
                              $"--------------------------");
        }

        public void TransferToTheAccount(BankAccount bankAccount, decimal amount)
        {
            bankAccount._balance -= amount;

            BankAccount recipientsBankAccount = new BankAccount(0, AccountType.SavingAccount);

            recipientsBankAccount._balance += amount;

            Console.WriteLine($"Перевод суммы: {amount} $ успешно выполнен!\nТекущий баланс: {bankAccount._balance} $");
        }
    }
}
