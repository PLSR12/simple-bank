using System;


namespace simple_bank.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate, double withdrawLimit)
            : base(number, holder, balance, withdrawLimit)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount, double withdrawLimit)
        {
            base.Withdraw(amount, withdrawLimit);
            // Call the base class method and add a rule to remove two more for withdrawal fee
            Balance -= 2.0;
        }
    }
}
