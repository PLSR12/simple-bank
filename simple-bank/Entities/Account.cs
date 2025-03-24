using System;
using simple_bank.Entities.Exceptions;

namespace simple_bank.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string? Holder { get; private set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; set; }


        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public virtual void Withdraw(double amount, double withdrawLimit)
        {

            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
         
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
