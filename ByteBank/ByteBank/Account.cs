﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Account
    {
        public int agencyNumber;
        public string accountNumber, accountHolder;
        public double balance = 100;


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
        public bool Transfer(double value, Account receiver)
        {
            if (this.balance < value)
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