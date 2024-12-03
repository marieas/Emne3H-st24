using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankappen
{
    internal class Bank
    {
        Customer _currentCustomer;

        public Bank()
        {
            _currentCustomer = new Customer("Kåre Knutsen",true);
            BankMenu();
        }

        void BankMenu()
        {
            Console.WriteLine($"Welcome to the bank {_currentCustomer.GetCustomerName()}");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Pay Bill");
            Console.WriteLine("4. Transfer Money To savings");
            Console.WriteLine("5. Check account balance");

            var userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    //Deposit money
                    Console.WriteLine("How much mo0ney do you want to deposit");
                    var input = Convert.ToInt32(Console.ReadLine());
                    _currentCustomer.DepositToSavingsAccount(input);
                    break;
                case "2":
                    //Deposit money
                    Console.WriteLine("How much mo0ney do you want to withdraw");
                    var withdrawSum = Convert.ToInt32(Console.ReadLine());
                    _currentCustomer.WithdrawMoney(withdrawSum,true);
                    break;
                case "3":
                    _currentCustomer.PrintBills();
                    Console.WriteLine("Please select bill id - of bill to pay");
                    var billId = int.Parse(Console.ReadLine());
                    _currentCustomer.PayBill(billId);
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;
            }

        }

      
    }
}
