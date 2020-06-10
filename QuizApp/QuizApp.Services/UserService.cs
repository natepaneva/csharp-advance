using System;
using QuizApp.Domain.User;
using System.Linq;

namespace QuizApp.Services
{
    public class UserService
    {
        public User[] Users { get; set; }

        public UserService()
        {
            Users = new User[]
            {
                new User()
                {
                    UserName = "student1",
                    Password = "student",
                    Role = Role.Student
                },
                new User()
                {
                    UserName = "student2",
                    Password = "student",
                    Role = Role.Student
                },
                new User()
                {
                    UserName = "student3",
                    Password = "student",
                    Role = Role.Student

                },
                new User()
                {
                    UserName = "student4",
                    Password = "student",
                    Role = Role.Student

                },
                new User()
                {
                    UserName = "teacher1",
                    Password = "teacher",
                    Role = Role.Teacher

                },
                new User()
                {
                    UserName = "teacher2",
                    Password = "teacher",
                    Role = Role.Teacher

                }
            };
        }
        public User LogIn(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.UserName == username && user.Password == password)
                    return user;
            }
            return null;

        }


        public void Grades(User[] Users)
        {
            foreach (var user in Users)
            {
                if (user.Role == Role.Student)
                {
                    if (!user.TookTest)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{user.UserName} did not take the test!");
                        Console.ResetColor();
                    }
                    if (user.TookTest == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (user.Grade == 0) Console.WriteLine($"{user.UserName}, Bad");
                        if (user.Grade == 1 || user.Grade == 2 || user.Grade == 3) Console.WriteLine($"{user.UserName}, Good");
                        if (user.Grade == 4) Console.WriteLine($"{user.UserName}, Very Good");
                        if (user.Grade == 5) Console.WriteLine($"{user.UserName}, Excelent");
                        Console.ResetColor();
                    }
                }
            }

        }
    }
}
