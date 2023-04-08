using ByteBankADM.Employees;
using System;

namespace ByteBankADM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe = new Employe();

            employe.Name = "Employe 01";
            employe.ID = "135.747.361-78";
            employe.Salary = 2000;

            Console.WriteLine("Employe name: " + employe.Name);
            Console.WriteLine("Employe salary bonus: " + employe.GetBonus());

            Console.Write("\nPress any key to close...");
            Console.ReadLine();
        }
    }
}