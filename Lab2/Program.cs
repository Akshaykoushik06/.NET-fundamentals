using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // callFun();
            callFun2();
        }

        static void callFun()
        {
            Account obj = new Account();
            obj.CreateAccount("Akshay", "Savings", 100000);
            Console.WriteLine($"Account details: ID = {obj.AccountId} Name = {obj.AccountHolderName} Type = {obj.AccountType} Balance = {obj.Balance}");
            obj.Credit(50000);
            Console.WriteLine($"After credit {obj.Balance}");
            obj.Debit(50000);
            Console.WriteLine($"After debit {obj.Balance}");
        }

        static void callFun2()
        {
            Account obj = new CurrentAccount();
            obj.CreateAccount("Akshay", "Current", 100000);
            Console.WriteLine($"Account details: ID = {obj.AccountId} Name = {obj.AccountHolderName} Type = {obj.AccountType} Balance = {obj.Balance}");
            obj.Credit(50000);
            Console.WriteLine($"After credit {obj.Balance}");
            obj.Debit(50000);
            Console.WriteLine($"After debit {obj.Balance}");

        }
    }

    class Account
    {
        #region Properties
        public int AccountId => 100;
        public string AccountHolderName { get; set; }
        public string AccountType { get; protected set; }
        public long Balance { get; set; }
        #endregion

        #region Methods
        public virtual void CreateAccount(string name, string type, long amount)
        {
            this.AccountHolderName = name;
            this.AccountType = type;
            this.Balance = amount;
        }

        public virtual void Credit(long amount)
        {
            this.Balance += amount;
        }

        public void Debit(long amount)
        {
            if(amount > this.Balance)
            {
                Console.WriteLine("You dont have enough funds!");
            }
            else
            {
                this.Balance -= amount;
            }
        }
        #endregion
    }

    class CurrentAccount: Account
    {
        #region Properties
        #endregion

        #region Methods
        public override void CreateAccount(string name, string type, long amount)
        {
            if(amount < 100000)
            {
                Console.WriteLine("You cannot create the account");
            }
            else
            {
                base.CreateAccount(name, type, amount);
            }
        }

        public override void Credit(long amount)
        {
            base.Credit(amount);
        }
        #endregion
    }

    class CreditAccount: Account
    {

    }
}
