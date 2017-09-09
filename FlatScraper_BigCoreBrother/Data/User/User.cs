namespace FlatScraper_BigCoreBrother.Data.User
{
    public class User
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public User(string name, string emailAddress)
        {
            Name = name;
            EmailAddress = emailAddress;
        }
    }
}
