using ByteBankADM.Employees;
using ByteBankADM.Utilitaries;
using ByteBankADM.InternalSystem;
using ByteBankADM.Partnership;

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

            CalcBonus();

            void CalcBonus()
            {
                BonusManager manager = new BonusManager();

                CEO director = new CEO("617.549.456-47");
                director.Name = "Scrooge McDuck";

                Designer designer01 = new Designer("132.149.167-81");
                designer01.Name = "Huey Duck";

                Assistant assistant01 = new Assistant("973.168.741-21");
                designer01.Name = "Dewey Duck";

                AccountManager accountManager01 = new AccountManager("348.974.358-69");
                designer01.Name = "Louie Duck";

                manager.Register(director);
                manager.Register(designer01);
                manager.Register(assistant01);
                manager.Register(accountManager01);

                General.Print("Total of all employees bonuses: $" + manager.BonusesTotal + ".");
            }

            General.Linebreak();

            UseLoginSystem();

            void UseLoginSystem()
            {
                BankSystem system = new BankSystem();

                CEO director02 = new CEO("074.801.374-16");
                director02.Name = "Launchpad McQuack";
                director02.Password = "123";

                AccountManager accountManager02 = new AccountManager("219.412.635-25");
                accountManager02.Name = "Donald Duck";
                accountManager02.Password = "321";

                BusinessPartner partner01 = new BusinessPartner();
                partner01.Password = "898";
                partner01.Name = "Gyro Gearloose";

                BusinessPartner partner02 = new BusinessPartner();
                partner02.Password = "777";
                partner02.Name = "José Carioca";

                system.Login(director02, "123");
                General.Linebreak();
                system.Login(accountManager02, "000");
                General.Linebreak();
                system.Login(partner01, "898");
                General.Linebreak();
                system.Login(partner02, "898");
                General.Linebreak();
            }

            Console.Write("Press any key to close...");
            Console.ReadLine();
        }
    }
}