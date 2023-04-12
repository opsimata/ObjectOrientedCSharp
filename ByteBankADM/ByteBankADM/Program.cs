using ByteBankADM.Employees;
using ByteBankADM.Utilitaries;

namespace ByteBankADM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Employe employe = new Employe("135.747.361-78", 10000);

            //employe.Name = "Louie Duck";
            ////employe.ID = "135.747.361-78";

            //General.Print("Employe name: " + employe.Name);
            //General.Print("Employe wage: $" + employe.Salary);
            //General.Print("Employe salary bonus: $" + employe.GetBonus());

            //General.Linebreak();

            //CEO director = new CEO("047.341.881-18");
            //director.Name = "Scrooge McDuck";
            ////director.ID = "047.341.881-18";

            //General.Print("CEO name: " + director.Name);
            //General.Print("CEO wage: $" + director.Salary);
            //General.Print("CEO salary bonus: $" + director.GetBonus());

            //BonusManager manager = new BonusManager();

            //manager.Register(employe);
            //manager.Register(director);

            //General.Linebreak();

            //General.Print("Total bonuses: $" + manager.BonusesTotal);

            //General.Linebreak();

            //General.Print("Total number of employees: " + Employe.EmployeesTotal);

            //General.Linebreak();

            //employe.IncreaseWage();
            //director.IncreaseWage();

            //General.Print("Employe new wage: $" + employe.Salary);
            //General.Print("CEO new wage: $" + director.Salary);
            #endregion

            General.Linebreak();

            Console.Write("Press any key to close...");
            Console.ReadLine();
        }
    }
}