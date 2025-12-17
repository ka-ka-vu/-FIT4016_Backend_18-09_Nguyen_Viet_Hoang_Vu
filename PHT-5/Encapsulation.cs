using System;

namespace Encapsulation

{
    class BankAccount
    {
        private double _balance;
        public double Balance
        {
            get { return _balance; }
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited: {amount}. New balance: {_balance}");
        }
        public void Withdraw(double amount)
        {
            if (amount > _balance)
            {
                Console.WriteLine("Khong du tien de rut!");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. New balance: {_balance}");
            }
        }
    }

    class Program

    {
        static void Main(string[] args)
        {


            BankAccount acc = new BankAccount();
            acc.Deposit(1000);
            acc.Withdraw(500);
            acc.Withdraw(700);
            Console.WriteLine($"Final Balance: {acc.Balance}");
        }
    }
}

