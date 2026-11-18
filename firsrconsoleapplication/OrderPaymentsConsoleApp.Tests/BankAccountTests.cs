using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OrderPaymentsConsoleApp.Tests
{
    public class BankAccountTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        public void BankAccount_SettingBankBalance_SetsExpectedBankBalance(decimal initialBalance)
        {
            //arrange
            BankAccount bankAccount;

            //act
            bankAccount = new BankAccount(initialBalance);

            //assert
            Assert.Equal(initialBalance, bankAccount.Balance);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-1526)]
        public void BankAccount_SettingNegativeBankBalance_ThrowsArgumentOutOfRangeException(decimal initialBalance)
        {
            //arrange
            BankAccount bankAccount;

            //act
            Action f = () => new BankAccount(initialBalance);

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(f);
        }
          
        [Theory]
        [InlineData(100, 50, 150)]
        [InlineData(0, 0.50, 0.50)]
        public void Deposit_DepositingAmount_AddsExpectedAmountToBankBalance(decimal initialBalance, decimal amount, decimal expectedBalance)
        {
            //arrange
            BankAccount bankAccount = new BankAccount(initialBalance);

            //act
            bankAccount.Deposit(amount);

            //assert
            Assert.Equal(bankAccount.Balance, expectedBalance);
        }

        [Theory]
        [InlineData(100, 0)]
        public void Deposit_DepositingZero_ThrowsArgumentOutOfRangeException(decimal initialBalance, decimal amount)
        {
            //arrange
            BankAccount bankAccount = new BankAccount(initialBalance);

            //act
            Action f = () => bankAccount.Deposit(amount);

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(f);
        }

        [Theory]
        [InlineData(100, -10)]
        public void Deposit_DepositingNegative_ThrowsArgumentOutOfRangeException(decimal initialBalance, decimal amount)
        {
            //arrange
            BankAccount bankAccount = new BankAccount(initialBalance);

            //act
            Action f = () => bankAccount.Deposit(amount);

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(f);
        }

        [Theory]
        [InlineData(100, 40, 60)]
        [InlineData(100, 100, 0)]
        public void TryWithdraw_WithdrawingPositiveAmount_ReturnsTrueAndChangesBalance(decimal initialBalance, decimal amount, decimal expectedBalance)
        {
            //arrange
            BankAccount bankAccount = new BankAccount(initialBalance);

            //act
            bool success = bankAccount.TryWithdraw(amount);


            //assert
            Assert.Equal(bankAccount.Balance, expectedBalance);
            Assert.True(success);
        }

        [Theory]
        [InlineData(100, 120)]
        [InlineData(0, 1)]
        public void TryWithdraw_WithdrawingZero_ReturnsFalseAndBalanceStaysTheSame(decimal initialBalance, decimal amount)
        {
            //arrange
            BankAccount bankAccount = new BankAccount(initialBalance);

            //act
            bool success = bankAccount.TryWithdraw(amount);

            //assert
            Assert.Equal(bankAccount.Balance, initialBalance);
            Assert.False(success);
        }

        [Theory]
        [InlineData(100, 0)]
        public void TryWithdraw_WithdrawingZero_ThrowsArgumentOutOfRangeExceptionAndBalanceStaysTheSame(decimal initialBalance, decimal amount)
        {
            //arrange
            BankAccount bankAccount = new BankAccount(initialBalance);

            //act
            Action f = () => bankAccount.TryWithdraw(amount);

            //assert
            Assert.Equal(bankAccount.Balance, initialBalance);
            Assert.Throws<ArgumentOutOfRangeException>(f);
        }

        [Theory]
        [InlineData(100, -10)]
        public void TryWithdraw_WithdrawingNegative_ThrowsArgumentOutOfRangeExceptionAndBalanceStaysTheSame(decimal initialBalance, decimal amount)
        {
            //arrange
            BankAccount bankAccount = new BankAccount(initialBalance);

            //act
            Action f = () => bankAccount.TryWithdraw(amount);

            //assert
            Assert.Equal(bankAccount.Balance, initialBalance);
            Assert.Throws<ArgumentOutOfRangeException>(f);
        }

    }
}
