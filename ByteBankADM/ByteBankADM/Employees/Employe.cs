using ByteBankADM.Utilitaries;

namespace ByteBankADM.Employees
{
    public class Employe
    {
        public string Name { get; set; }
        public string ID { get; private set; }
        public double Salary { get; protected set; }
        public static int EmployeesTotal { get; private set; }

        public Employe(string id, double salary)
        {
            this.ID = id;
            this.Salary = salary;
            EmployeesTotal++; //Incrementa CEO por herança
        }

        public virtual void IncreaseWage()
        {
            this.Salary *= 1.08;
        }
        public virtual double GetBonus()
        {
            return this.Salary * 0.1;
        }
    }
}
