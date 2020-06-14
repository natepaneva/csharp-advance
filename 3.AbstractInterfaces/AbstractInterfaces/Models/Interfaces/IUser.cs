using System;
namespace AbstractInterfaces.Models.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        void PrintUser(string name, string username, string password);

    }
}
