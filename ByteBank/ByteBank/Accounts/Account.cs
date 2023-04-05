using ByteBank.Client;

namespace ByteBank.Accounts
{
    public class Account
    {
        public int agencyNumber;
        public int AgencyNumber
        {
            get { return this.agencyNumber; }
            private set
            {
                if (value > 0)
                {
                    this.agencyNumber = value;
                }
            }
        }

        //public string accountNumber;

        public string AccountNumber { get; set; }
        public AccountHolder AccountHolder { get; set; }

        private double accountBalance;
        public void Deposit(double value)
        {
            accountBalance += value;
        }

        public void PrintData()
        {
            Console.WriteLine("Client: " + AccountHolder.Name);
            Console.WriteLine("Client ID: " + AccountHolder.ID);
            Console.WriteLine("Client profession: " + AccountHolder.Profession);
            Console.WriteLine("Account number: " + AccountNumber);
            Console.WriteLine("Agency number: " + agencyNumber);
            Console.WriteLine("Balance: $" + accountBalance);
        }

        public bool Withdraw(double value)
        {
            if (value <= accountBalance)
            {
                accountBalance -= value;
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
            if (accountBalance < value)
            {
                Console.WriteLine("\nInvalid operation!\nNo sufficient founds!\n");
                return false;
            }
            else
            {
                Withdraw(value);
                receiver.Deposit(value);
                return true;
            }
        }

        public void SetBalance(double value)
        {
            if (value < 0)
            {
                return;
            }
            else
            {
                this.accountBalance = value;
            }
        }

        public double GetBalance()
        {
            return this.accountBalance;
        }

        public Account(int agencyNumber, string accountNumber)
        {
            this.AgencyNumber = agencyNumber;
            this.AccountNumber = accountNumber;
        }
    }
}