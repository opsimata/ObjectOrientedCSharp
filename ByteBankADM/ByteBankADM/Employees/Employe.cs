using ByteBankADM.Utilitaries;

namespace ByteBankADM.Employees
{
    public class Employe
    {
        public string Name { get; set; }
        public string ID { get; private set; }
        public double Salary { get; set; }
        public static int EmployeesTotal { get; private set; }

        public Employe(string id)
        {
            this.ID = id;
            EmployeesTotal++; //Incrementa CEO por herança
        }

        public virtual double GetBonus()
        {
            return this.Salary * 0.1;
        }
    }
}
