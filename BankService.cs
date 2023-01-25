using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankService
    {
        private Dictionary<int, IAccount> bankAccounts;
        public BankService()
        {
            bankAccounts = new Dictionary<int, IAccount>();
        }

        public Dictionary<int, IAccount> GetOwnerAccounts(int ownerId)
        {
            IAccount checkingAccount = new CheckingAccount();
            IAccount personalInvestment = new PersonalInvestmentAccount();
            IAccount corporateInvestment = new CorporateInvestmentAccount();

            if (checkingAccount.GetAccountNumber(ownerId) != 0)
                bankAccounts.Add(checkingAccount.GetAccountNumber(ownerId), checkingAccount);

            if (personalInvestment.GetAccountNumber(ownerId) != 0)
                bankAccounts.Add(personalInvestment.GetAccountNumber(ownerId), personalInvestment);

            if (corporateInvestment.GetAccountNumber(ownerId) != 0)
                bankAccounts.Add(corporateInvestment.GetAccountNumber(ownerId), corporateInvestment);

            return bankAccounts;
        }

        public float GetBalance(int cusAccount)
        {
            IAccount account = bankAccounts[cusAccount];
            return account.Balance();
        }

        public float WithdrawlMoney(int fromAcct, float amount)
        {
            IAccount fromAccount = bankAccounts[fromAcct];
            return fromAccount.Withdraw(amount);
        }

        public float DepositMoney(int cusAcct, float amount)
        {
            IAccount account = bankAccounts[cusAcct];
            return account.Deposit(amount);
        }

        public float TransferMoney(int receivingAcct, int sendingAcct, float amount)
        {
            IAccount receivingAccount = bankAccounts[receivingAcct];
            IAccount sendingAccount = bankAccounts[sendingAcct];
            return sendingAccount.Transfer(receivingAccount, amount);
        }
    }
}
