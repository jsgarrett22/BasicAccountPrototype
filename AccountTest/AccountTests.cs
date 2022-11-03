using AccountStuff;

namespace AccountTest
{
    public class AccountTests
    {
        [Fact]
        public void TestPositiveWithdrawal()
        {
            // $50.00 over withdrawal
            Account acc = new Account("000302019", "John Doe", 1362.59M);
            acc.Withdraw(1412.59M);
            Assert.Equal(-50.00M, acc.Balance, 2);

            // $99.99 over withdrawal
            Account acc1 = new Account("000302019", "John Doe", 1362.59M);
            acc1.Withdraw(1462.58M);
            Assert.Equal(-99.99M, acc1.Balance, 2);

            // $100.00 over withdrawal
            Account acc2 = new Account("000302019", "John Doe", 1362.59M);
            Assert.Throws<Exception>(
                () => acc2.Withdraw(1462.59M)
            );
        }

        [Fact]
        public void TestNegativeWithdrawal()
        {
            Account acc = new Account("000302019", "John Doe", 1362.59M);

            Assert.Throws<Exception>(
                () => acc.Withdraw(-100.00M)
            );
        }

        [Fact]
        public void TestSpecificWithdrawal()
        {
            Account acc = new Account("000302019", "John Doe", 1362.59M);
            acc.Withdraw(99.09M);
            Assert.Equal(1263.50M, acc.Balance, 2);
        }

        [Fact]
        public void TestMaximumDeposit()
        {
            Account acc = new Account("000302019", "John Doe", 1362.59M);

            Assert.Throws<Exception>(
                () => acc.Deposit(10000.00M)
            );

            Assert.Throws<Exception>(
                () => acc.Deposit(20000.00M)
            );
        }

        [Fact]
        public void TestMinimumDeposit()
        {
            Account acc = new Account("000302019", "John Doe", 1362.59M);

            Assert.Throws<Exception>(
                () => acc.Deposit(0.0M)
            );

            Assert.Throws<Exception>(
                () => acc.Deposit(-10000.0M)
            );
        }

        [Fact]
        public void AccountNumberTest()
        {
            Account myAcc = new Account("0123456789", "John Doe", 1362.59M);
            Assert.NotEqual("000302019", myAcc.Number);

            Account myAcc1 = new Account("000302019", "John Doe", 1362.59M);
            Assert.Equal("000302019", myAcc1.Number);
        }

        [Fact]
        public void AccountIsAccountTest()
        {
            Account myAcc = new Account("000302019", "John Doe", 1362.59M);
            Assert.IsType<Account>(myAcc);
        }

        [Fact]
        public void TestNegativeBalance()
        {
            
        }
    }
}