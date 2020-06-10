using System;
namespace QuizApp.Domain.User
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public bool TookTest { get; set; }
        public int Grade { get; set; }

        public User()
        {
        }

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
