using ByteBankADM.Employees;
using ByteBankADM.Partnership;
using ByteBankADM.Utilitaries;

namespace ByteBankADM.InternalSystem
{
    public class BankSystem
    {
        public bool Login(IAuthenticator employe, string password)
        {
            bool authenticatedUser = employe.Authentication(password);

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
