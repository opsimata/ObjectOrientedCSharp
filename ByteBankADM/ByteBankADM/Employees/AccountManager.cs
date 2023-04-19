using ByteBankADM.InternalSystem;
using ByteBankADM.Utilitaries;

namespace ByteBankADM.Employees
{
    public class AccountManager : AuthenticableEmploye

    {
        public AccountManager(string id) : base(id, 7000)
        {
        }
        public override void IncreaseWage()
        {
            this.Salary *= .1;
        }
        public override double GetBonus()
        {
            return this.Salary * .05;
        }
    }
}