using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class CheckingAccount : IAccount
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
                    return 5551111;
                case 4567:
                    return 4441111;
                case 333:
                    return 3331111;
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
            return 1000;
        }
    }
}
