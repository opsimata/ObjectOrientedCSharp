using ByteBank.Client;

namespace ByteBank.Accounts
{
    public class Account
    {
        public int agencyNumber;
        public string accountNumber;
        private double accountBalance = 100;

        public AccountHolder accountHolder;

        public void Deposit(double value)
        {
            accountBalance += value;
        }

        public void PrintData()
        {
            Console.WriteLine("Client: " + accountHolder.name);
            Console.WriteLine("Client ID: " + accountHolder.ID);
            Console.WriteLine("Client profession: " + accountHolder.profession);
            Console.WriteLine("Account number: " + accountNumber);
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
    }
}