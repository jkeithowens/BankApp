using BankApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankUnitTestProject
{
    [TestClass]
    public class BankUnitTests
    {
        [TestMethod]
        public void DepositMoney_PositiveValue_ShouldReturnIncreaseBalance()
        {
            var bankService = new BankService();

            var customerCheckingAccount = 5551111;

            bankService.GetOwnerAccounts(1234);

            var balanceAfterDeposit = bankService.DepositMoney(customerCheckingAccount, 500);

            Assert.AreEqual(1500, balanceAfterDeposit);

        }

        [TestMethod]
        public void WithdrawlMoney_LessThan500_ShouldReturnDecreaseBalance()
        {
            var bankService = new BankService();

            var personalInvestmentAccount = 12341111;

            bankService.GetOwnerAccounts(1234);

            var balanceAfterWithdrawl = bankService.WithdrawlMoney(personalInvestmentAccount, 100);

            Assert.AreEqual(4900, balanceAfterWithdrawl);

        }


        [TestMethod]
        public void WithdrawlMoney_MoreThan500_ShouldNotChange()
        {
            var bankService = new BankService();

            var personalInvestmentAccount = 12341111;

            bankService.GetOwnerAccounts(1234);

            var balanceAfterWithdrawl = bankService.WithdrawlMoney(personalInvestmentAccount, 600);

            Assert.AreEqual(5000, balanceAfterWithdrawl);

        }

        [TestMethod]
        public void TransferMoney_CheckingToInvestment_ShouldIncreaseReceivingAccountAndDecreaseSendingAccount()
        {
            var bankService = new BankService();
            var personalInvestmentAccount = 12341111;
            var customerCheckingAccount = 5551111;

            bankService.GetOwnerAccounts(1234);

            var checkingBalance = bankService.TransferMoney(personalInvestmentAccount, customerCheckingAccount, 100);

            Assert.AreEqual(900, checkingBalance);

        }
    }
}
