using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class CorporateInvestmentAccount : IAccount
    {
        public float Deposit(float amount)
        {
            return Balance() + amount;
        }

        public int GetAccountNumber(int ownerId)
        {
            switch (ownerId)
            {
                case 9999:
                    return 99991111;
                case 8888:
                    return 88881111;
                case 7777:
                    return 77771111;
                default:
                    return 0;
            }
        }

        public float Transfer(IAccount account, float amount)
        {
            account.Deposit(amount);
            return Balance() - amount;
        }

        public float Withdraw(float amount)
        {
            return Balance() - amount;
        }

        public float Balance()
        {
            return 100000;
        }

    }
}
