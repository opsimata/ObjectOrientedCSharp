﻿using ByteBank.Accounts;
using ByteBank.Client;

class Program
{
    static void Main(string[] args)
    {
        //Account account01 = new Account();

        //account01.accountHolder = "Person 01";
        //account01.agencyNumber = 15;
        //account01.accountNumber = "1011-9";
        //account01.accountBalance = 1000;

        //Console.WriteLine("\nAccount holder: " + account01.accountHolder + "." + "\nAccount balance: $" + account01.accountBalance + "." + "\nAgency number: " + account01.agencyNumber + "." + "\nAccount number: " + account01.accountNumber + ".");

        //Account account04 = new Account();

        //account04.accountHolder = "Person 01";
        //account04.agencyNumber = 15;
        //account04.accountNumber = "1011-9";
        //account04.accountBalance = 1000;

        //Console.WriteLine("\nAccount holder: " + account04.accountHolder + "." + "\nAccount balance: $" + account04.accountBalance + "." + "\nAgency number: " + account04.agencyNumber + "." + "\nAccount number: " + account04.accountNumber + ".");

        //account01 = account04;

        //Console.WriteLine("\n");
        //Console.WriteLine(account01 == account04);

        //Account account02 = new Account();

        //account02.accountHolder = "Person 02";
        //account02.agencyNumber = 34;
        //account02.accountNumber = "2178-4";
        //account02.accountBalance = 300;

        //Console.WriteLine(account01.accountHolder + " account balance: $" + account01.accountBalance + ".");

        //account01.Deposit(100);

        //Console.WriteLine(account02.accountHolder + " account balance: $" + account02.accountBalance + ".");

        //account01.Transfer(150, account02);

        //Console.WriteLine(account01.accountHolder + " account balance: $" + account01.accountBalance + ".");
        //Console.WriteLine(account02.accountHolder + " account balance: $" + account02.accountBalance + ".");

        //Account account03 = new Account();
        //account03.accountHolder = "Person 03";
        //Console.WriteLine("\nAccount holder: " + account03.accountHolder + "." + "\nAccount balance: $" + account03.accountBalance + "." + "\nAgency number: " + account03.agencyNumber + "." + "\nAccount number: " + account03.accountNumber + ".");

        //account01.PrintData();

        //AccountHolder client = new AccountHolder();
        //client.name = "Client 01";
        //client.ID = "020.441.248-85";
        //client.profession = "Architect";

        //Account account = new Account();
        //account.accountHolder = client;
        //account.agencyNumber = 1;
        //account.accountNumber = "1674-4";
        //account.accountBalance = 1000;

        //account.PrintData();


        //Account account02 = new Account();
        //account02.accountHolder = new AccountHolder();
        //account02.accountHolder.name = "Client 02";
        //account02.accountHolder.ID = "165.149.452.14";
        //account02.accountHolder.profession = "Teacher";
        //account02.agencyNumber = 41;
        //account02.accountNumber = "3541-7";
        //account02.accountBalance = 6741.21;

        //Console.WriteLine("\n" + account02.accountHolder.name);

        Account account03 = new Account();
        account03.SetBalance(200);
        Console.WriteLine(account03.GetBalance());

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}