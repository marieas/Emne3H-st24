using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankappen
{
    internal class Customer
    {
        //public string CustomerName { get; private set; } Property
        //public string CustomerName { get { return _customerName; } set { _customerName = value; } } //bak kulissene
        string _customerName; //beskyttet variabel (private)
        string _socialSecurityNumber;
        Account _savingsAccount;
        Account _currentAccount; //Brukskonto

        public Customer(string customerName)
        {
            _customerName = customerName;
            _savingsAccount = new Account(true, "Savings");
            _currentAccount = new Account(false, "Brukskonton");
        }
        public string GetCustomerName()
        {
            return _customerName;
        }

        public void WithdrawMoney(int sum, bool fromSavingsAccount)
        {
            if(fromSavingsAccount)
            {
                _savingsAccount.Withdraw(sum);
            }
            else
            {
                _currentAccount.Withdraw(sum);
            }
        }
        public void DepositToSavingsAccount(int amount)
        {
            _savingsAccount.DepositMoney(amount);
        }

        public void DepositToCurrentAccount()
        {

        }
    }
}
