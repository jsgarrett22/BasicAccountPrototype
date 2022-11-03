using AccountStuff;
using System;

namespace UnitTests
{
    public class TransactionTests
    {
        [Fact]
        public void NewTransactionTest()
        {
            Transaction newTransaction = new Transaction(DateTime.Now, 1362.59M);
            Assert.Equal(1362.59M, newTransaction.Amount);
            Assert.NotEqual(-1362.59M, newTransaction.Amount);
        }

        [Fact]
        public void TransactionTypeTest()
        {
            Transaction newTransaction = new Transaction(DateTime.Now, 1362.59M);

            // Transaction amount is positive therefore the type should be a Deposit
            Assert.Equal(TransactionType.Deposit, newTransaction.Type);

            // Transaction amount is negative therefore the type should be a Withdrawal
            Assert.Equal(TransactionType.Withdrawal, newTransaction.Type);
        }
    }
}
