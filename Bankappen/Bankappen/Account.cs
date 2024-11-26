using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bankappen
{
    internal class Account
    {
        int _balance;
        string _accountName;
        bool _savingsAccount;
        string _accountNumber;
        string[] _accountTransactions;

        public Account(bool isSavingsAccount, string accountName)
        {
            _savingsAccount = isSavingsAccount;
            _accountName = accountName;
            _balance = 0;
            _accountTransactions = new string[100];
            _accountNumber = new Guid().ToString();   
        }

        public void DepositMoney(int amountToDeposit)
        {
            _balance += amountToDeposit;
        }
        public void Withdraw(int sum)
        {
            if(_balance >= sum)
            {
                _balance -= sum;
            }
            else
            {
                Console.WriteLine("You dont have enough mo0ney");
            }
           
        }
    }
}
