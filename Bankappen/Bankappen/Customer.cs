using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankappen
{//Pause til 11.00
    internal class Customer
    {
        //public string CustomerName { get; private set; } Property
        //public string CustomerName { get { return _customerName; } set { _customerName = value; } } //bak kulissene
        private string _customerName; //beskyttet variabel (private)
        private string _socialSecurityNumber;
        private Account _savingsAccount;
        private Account _currentAccount; //Brukskonto
        private List<Bill> _bills;

        public Customer(string customerName)
        {
            _customerName = customerName;
            _savingsAccount = new Account(true, "Savings");
            _currentAccount = new Account(false, "Brukskonton");
            _bills = new List<Bill>(); //tom liste
        }
        public Customer(string customerName,bool hasBills)
        {
            _customerName = customerName;
            _savingsAccount = new Account(true, "Savings");
            _currentAccount = new Account(false, "Brukskonton");
           
            _bills = new List<Bill>() { new Bill(1,5293,"0202001149",new DateTime(2024,12,24)), new Bill(2,284782, "93923728919", new DateTime(2025, 1, 4)), new Bill(3,384, "924981781", new DateTime(2024, 12, 24)), new Bill(4,1, "29847281", new DateTime(2025, 5, 12)) };
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
        public void PayBill(int billId)
        {
            //finne en regning
            var bill = GetBill(billId);

            //trekke penger fra konto
            _currentAccount.Withdraw(bill.Amount);

            //fjerne regning fra liste
            _bills.Remove(bill);
            //evt legge til transaction i konto?
            _currentAccount.AddNewTransaction("Paid bill " + bill.KidNr);
        }

        public Bill GetBill(int billId)
        {
            Bill foundBill = _bills.First(bill => bill.Id == billId);
            return foundBill;
        }

        public void PrintBills()
        {
            
            foreach (Bill bill in _bills)
            {
                Console.WriteLine($"BillId: {bill.Id} Billnr: {bill.KidNr} Amount: {bill.Amount} DueDate: {bill.PayDate.ToShortDateString()}");
                
            }
        }
    }
}
