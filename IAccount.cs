using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public interface IAccount
    {
        float Deposit(float amount);
        float Balance();
        float Withdraw(float amount);
        float Transfer(IAccount account, float amount);
        int GetAccountNumber(int ownerId);
    }
}
