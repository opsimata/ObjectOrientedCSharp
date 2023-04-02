using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Account
    {
        public int AgencyNumber;
        public string accountNumber, accountHolder;
        public double balance;


        public void Deposit(double value)
        {
            this.balance += value;
        }

        public bool Withdraw(double value)
        {
            if (value <= this.balance)
            {
                this.balance -= value;
                return true;
            }
            else
            {
                Console.WriteLine("\nInvalid operation!\nNo sufficient founds!\n");
                return false;
            }
        }
    }
}