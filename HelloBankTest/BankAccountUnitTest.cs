using System;
using Bank;
using NUnit.Framework;

namespace HelloBankTest
{
    [TestFixture]
    public class UnitTests
    {
        private BankAccount account = null;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        [Test]
        public void Adding_Funds_Updates_Balance()
        {
            // Act
            account.Add(500);

            // Assert
            Assert.AreEqual(1500, account.Balance);
        }

        [Test]
        [Category("Exception Tests")]
        public void Adding_Negative_Funds_Throws()
        {
            // Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-500));
        }

        [Test]
        public void Withdrawing_Funds_Updates_Balance()
        {
            // Act
            account.Withdraw(500);

            // Assert
            Assert.AreEqual(500, account.Balance);
        }

        [Test]
        [Ignore("This is an example for ignore demo")]
        public void Transfering_Funds_Updates_Both_Account()
        {
            // Nothing...
        }
    }
}
