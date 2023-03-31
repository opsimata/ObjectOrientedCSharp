using ByteBank;

Account account01 = new Account();

account01.accountHolder = "Person 01";
account01.AgencyNumber = 15;
account01.accountNumber = "1011-9";
account01.balance = 1000;

Console.WriteLine(account01.accountHolder + " account balance: $" + account01.balance);

Console.Write("\nPress any key to close...");
Console.ReadLine();