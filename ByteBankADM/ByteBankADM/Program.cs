using ByteBankADM.Employees;
using ByteBankADM.Utilitaries;

namespace ByteBankADM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employe employe = new Employe();

            employe.Name = "Louie Duck";
            employe.ID = "135.747.361-78";
            employe.Salary = 2000;

            Console.WriteLine("Employe name: " + employe.Name);
            Console.WriteLine("Employe salary bonus: $" + employe.GetBonus());

            BonusManager.Linebreak();

            CEO director = new CEO();
            director.Name = "Scrooge McDuck";
            director.ID = "047.341.881-18";
            director.Salary = 150000;

            Console.WriteLine("CEO name: " + director.Name);
            Console.WriteLine("CEO salary bonus: $" + director.GetBonus());

            BonusManager manager = new BonusManager();

            manager.Register(employe);
            manager.Register(director);

            BonusManager.Print("Total bonuses: $" + manager.BonusTotal);

            Console.Write("\nPress any key to close...");
            Console.ReadLine();
        }
    }
}