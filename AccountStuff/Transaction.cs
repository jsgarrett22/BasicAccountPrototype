using System;

namespace AccountStuff
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }

        public Transaction(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
            if (amount >= 0)
            {
                this.Type = TransactionType.Deposit;
            } else
            {
                this.Type = TransactionType.Withdrawal;
            }
        }
    }

    public enum TransactionType
    {
        Withdrawal, Deposit
    }
}
