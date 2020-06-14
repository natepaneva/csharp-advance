using System;
using AbstractInterfaces.Models.Interfaces;

namespace AbstractInterfaces.Models
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set ; }
        public string Password { get; set; }

        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public void PrintUser(string name, string username, string password)
        {
            Console.WriteLine($"Name: {name} | Username: {username} | Password: {password}");
        }
    }
}
