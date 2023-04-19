using ByteBankADM.InternalSystem;

namespace ByteBankADM.Partnership
{
    public class BusinessPartner : IAuthenticator
    {

        public string Password { get; set; }
        public string Name { get; set; }

        public bool Authentication(string password)
        {
            return this.Password == password;
        }
    }
}
