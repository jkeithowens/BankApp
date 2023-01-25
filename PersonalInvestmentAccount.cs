using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class PersonalInvestmentAccount : IAccount
    {

        public float Deposit(float amount)
        {
            return Balance() + amount;
        }

        public int GetAccountNumber(int ownerId)
        {
            switch (ownerId)
            {
                case 1234:
                    return 12341111;
                case 4568:
                    return 56781111;
                case 7890:
                    return 78901111;
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
            if (AllowableTransferAmount(amount))
                return Balance() - amount;
            Console.WriteLine("Max Withdrawl of $500, transaction cancelled");
            return Balance();
        }

        public float Balance()
        {
            return 5000;
        }

        private bool AllowableTransferAmount(float amount)
        {
            return amount <= 500;
        }
    }
}
