using ByteBankADM.Employees;
using ByteBankADM.Utilitaries;

namespace ByteBankADM.InternalSystem
{
    public class BankSystem
    {
        public bool Login(Authenticator employe, string password, string login)
        {
            bool authenticatedUser = employe.Authentication(password, login);

            if (authenticatedUser == true)
            {
                General.Print("User: " + employe.Name + "\nLogin Authorized! Welcome!");
                return true;
            }
            else
            {
                General.Print("User: " + employe.Name + "\nLogin Unauthorized! Wrong Credentials!");
                return false;
            }
        }
    }
}
