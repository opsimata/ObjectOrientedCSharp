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
            employe.Salary = 12000;

            General.Print("Employe name: " + employe.Name);
            General.Print("Employe salary bonus: $" + employe.GetBonus());

            General.Linebreak();

            CEO director = new CEO();
            director.Name = "Scrooge McDuck";
            director.ID = "047.341.881-18";
            director.Salary = 150000;

            General.Print("CEO name: " + director.Name);
            General.Print("CEO salary bonus: $" + director.GetBonus());

            BonusManager manager = new BonusManager();

            manager.Register(employe);
            manager.Register(director);

            General.Linebreak();

            General.Print("Total bonuses: $" + manager.BonusesTotal);

            Console.Write("\nPress any key to close...");
            Console.ReadLine();
        }
    }
}