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
    }
}