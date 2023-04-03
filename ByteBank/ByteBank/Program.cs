using ByteBank;

class Program
{
    static void Main(string[] args)
    {
        Account account01 = new Account();

        account01.accountHolder = "Person 01";
        account01.agencyNumber = 15;
        account01.accountNumber = "1011-9";
        account01.balance = 1000;

        Console.WriteLine("\nAccount holder: " + account01.accountHolder + "." + "\nAccount balance: $" + account01.balance + "." + "\nAgency number: " + account01.agencyNumber + "." + "\nAccount number: " + account01.accountNumber + ".");

        Account account04 = new Account();

        account04.accountHolder = "Person 01";
        account04.agencyNumber = 15;
        account04.accountNumber = "1011-9";
        account04.balance = 1000;

        Console.WriteLine("\nAccount holder: " + account04.accountHolder + "." + "\nAccount balance: $" + account04.balance + "." + "\nAgency number: " + account04.agencyNumber + "." + "\nAccount number: " + account04.accountNumber + ".");

        account01 = account04;

        Console.WriteLine("\n");
        Console.WriteLine(account01 == account04);

        //Account account02 = new Account();

        //account02.accountHolder = "Person 02";
        //account02.agencyNumber = 34;
        //account02.accountNumber = "2178-4";
        //account02.balance = 300;

        //Console.WriteLine(account01.accountHolder + " account current balance: $" + account01.balance + ".");

        //account01.Deposit(100);

        //Console.WriteLine(account02.accountHolder + " account current balance: $" + account02.balance + ".");

        //account01.Transfer(150, account02);

        //Console.WriteLine(account01.accountHolder + " account current balance: $" + account01.balance + ".");
        //Console.WriteLine(account02.accountHolder + " account current balance: $" + account02.balance + ".");

        //Account account03 = new Account();
        //account03.accountHolder = "Person 03";
        //Console.WriteLine("\nAccount holder: " + account03.accountHolder + "." + "\nAccount balance: $" + account03.balance + "." + "\nAgency number: " + account03.agencyNumber + "." + "\nAccount number: " + account03.accountNumber + ".");




        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}