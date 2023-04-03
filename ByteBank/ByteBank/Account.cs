using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Account
    {
        public int agencyNumber;
        public string accountNumber;
        public double accountBalance = 100;

        public AccountHolder accountHolder;

        public void Deposit(double value)
        {
            this.accountBalance += value;
        }

        public void PrintData()
        {
            Console.WriteLine("Holder: " + accountHolder.name);
            Console.WriteLine("Holder ID: " + accountHolder.ID);
            Console.WriteLine("Holder profession: " + accountHolder.profession);
            Console.WriteLine("Account number: " + accountNumber);
            Console.WriteLine("Agency number :" + agencyNumber);
            Console.WriteLine("Balance: $" + accountBalance);
        }

        public bool Withdraw(double value)
        {
            if (value <= this.accountBalance)
            {
                this.accountBalance -= value;
                return true;
            }
            else
            {
                Console.WriteLine("\nInvalid operation!\nNo sufficient founds!\n");
                return false;
            }
        }
        public bool Transfer(double value, Account receiver)
        {
            if (this.accountBalance < value)
            {
                Console.WriteLine("\nInvalid operation!\nNo sufficient founds!\n");
                return false;
            }
            else
            {
                this.Withdraw(value);
                receiver.Deposit(value);
                return true;
            }
        }
    }
}