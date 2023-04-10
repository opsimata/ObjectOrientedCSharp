using ByteBankADM.Employees;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ByteBankADM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void Linebreak()
            {
                Console.WriteLine("\n");
            } 

            Employe employe = new Employe();

            employe.Name = "Louie Duck";
            employe.ID = "135.747.361-78";
            employe.Salary = 2000;

            Console.WriteLine("Employe name: " + employe.Name);
            Console.WriteLine("Employe salary bonus: $" + employe.GetBonus());

            Linebreak();

            CEO director = new CEO();
            director.Name = "Scrooge McDuck";
            director.ID = "047.341.881-18";
            director.Salary = 150000;

            Console.WriteLine("CEO name: " + director.Name);
            Console.WriteLine("CEO salary bonus: $" + director.GetBonus());

            Console.Write("\nPress any key to close...");
            Console.ReadLine();
        }
    }
}