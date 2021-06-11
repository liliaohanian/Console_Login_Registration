

namespace Login_BetHomework
{
    public class User
    {
        public string name;
        public string surname;
        public string username;
        public string password;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string name, string surname,  string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }
        public User()
        {

        }
        
    }
}
