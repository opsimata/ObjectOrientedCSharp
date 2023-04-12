namespace ByteBankADM.Employees
{
    public class CEO : Employe
    {
        public override double GetBonus()
        {
            return this.Salary;
        }
    }
}