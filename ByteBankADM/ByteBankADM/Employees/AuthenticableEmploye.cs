using ByteBankADM.InternalSystem;

namespace ByteBankADM.Employees
{
    public abstract class AuthenticableEmploye : Employe, IAuthenticator
    {

        public string Password { get ; set ; }
        protected AuthenticableEmploye(string id, double salary) : base(id, salary)
        {

        }
        public bool Authentication(string password)
        {
            return this.Password == password;
        }
    }
}
