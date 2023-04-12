using ByteBankADM.Utilitaries;

namespace ByteBankADM.Employees
{
    public class Employe
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Salary { get; set; }
        public static int EmployeesTotal { get; private set; }

        public Employe(string id)
        {
            this.ID = id;
            EmployeesTotal++; //Incrementa CEO por conta da herança
        }

        public virtual double GetBonus()
        {
            return this.Salary * 0.1;
        }
    }
}
