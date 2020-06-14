using System;
using System.Collections.Generic;
using AbstractInterfaces.Models.Interfaces;

namespace AbstractInterfaces.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student(int id, string name, string username, string password, List<int> grades)
            : base(id, name, username, password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
            Grades = grades;
        }


        public void PrintUser(List<int> grades)
        {
            Console.WriteLine($"Welcome. Your current grades are: ");
            foreach (int grade in grades)
            {
                Console.WriteLine($"{grade}");
            }
        }
    }
}
