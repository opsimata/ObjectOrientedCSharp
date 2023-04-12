using ByteBankADM.Utilitaries;

namespace ByteBankADM.Employees
{
    public class CEO : Employe
    {

        public CEO()
        {
        }
        public override double GetBonus()
        {
            //return this.Salary + (base.GetBonus() * .35);
            return this.Salary * .35;
        }
    }
}