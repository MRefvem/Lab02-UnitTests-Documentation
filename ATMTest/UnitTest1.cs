using System;
using Xunit;
using static UnitTesting.Program;

namespace ATMTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestViewBalance()
        {
            // Arrange
            decimal value = 100;
            Balance = value;

            // Act
            decimal result = ViewBalance();

            // Assert
            Assert.Equal(value, result);

        }

        [Fact]
        public void TestViewBalance2()
        {

            // Arrange
            decimal value = 500;
            Balance = value;

            // Act
            decimal result = ViewBalance();

            // Assert
            Assert.Equal(value, result);
        
        }

        [Fact]
        public void TestWithdrawal()
        {

            // Arrange
            decimal value = 100;
            Balance = value;
            decimal withdrawal = 50;

            // Act
            decimal expected = 50;
            decimal result = Withdraw(withdrawal);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void TestWithdrawalAmountGreaterThanBalance()
        {

            // Arrange
            decimal value = 500;
            Balance = value;
            decimal withdrawal = 600;

            // Act
            decimal expected = 500;
            decimal result = Withdraw(withdrawal);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void TestWithdrawalNegativeAmount()
        {

            // Arrange
            decimal value = 800;
            Balance = value;
            decimal withdrawal = -200;

            // Act
            decimal expected = 800;
            decimal result = Withdraw(withdrawal);

            // Assert
            Assert.Equal(expected, result);


        }

        [Fact]
        public void TestDeposit()
        {

            // Arrange
            decimal value = 100;
            Balance = value;
            decimal deposit = 200;

            // Act
            decimal expected = 300;
            decimal result = Deposit(deposit);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void TestDepositNegativeAmount()
        {

            // Arrange
            decimal value = 500;
            Balance = value;
            decimal deposit = -50;

            // Act
            decimal expected = 500;
            decimal result = Deposit(deposit);

            // Assert
            Assert.Equal(expected, result);


        }
    }
}
