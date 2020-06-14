using System;
using System.Collections.Generic;
using AbstractInterfaces.Models.Interfaces;

namespace AbstractInterfaces.Models
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; }

        public Teacher(int id, string name, string username, string password, List<string> subjects)
            :base(id, name, username, password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
            Subjects = subjects;
        }

        public void PrintUser(List<string> subjects)
        {
            Console.WriteLine($"Welcome. Your current subjects are: ");
            foreach (string subject in subjects)
            {
                Console.WriteLine($"{subject}");

            }

        }
    }
}
