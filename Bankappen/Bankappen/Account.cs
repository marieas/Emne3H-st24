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
        List<string> _accountTransactions;

        public Account(bool isSavingsAccount, string accountName)
        {
            _savingsAccount = isSavingsAccount;
            _accountName = accountName;
            _balance = 10000;
            _accountTransactions = new List<string>();
            _accountNumber = new Guid().ToString();   
        }

        public void AddNewTransaction(string transactionText)
        {
            _accountTransactions.Add(transactionText);
            Console.WriteLine("Added: " + _accountTransactions[0]);
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
