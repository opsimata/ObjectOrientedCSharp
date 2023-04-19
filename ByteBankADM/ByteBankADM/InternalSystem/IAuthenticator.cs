namespace ByteBankADM.InternalSystem
{
    public interface IAuthenticator
    {
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Authentication(string password);
    }
}
