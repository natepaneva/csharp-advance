using System;
using System.Collections.Generic;
using AbstractInterfaces.Models;

namespace AbstractInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(1, "John", "johndoe", "john123", new List<string> { "Math", "Physics" });
            Teacher teacher2 = new Teacher(2, "Joana", "joanadoe", "joana123", new List<string> { "English", "French" });

            Student student1 = new Student(101, "Natasha", "natepaneva", "nate123", new List<int> {10, 9, 10, 8});
            Student student2 = new Student(102, "Blagoja", "bazemitreski", "baze123", new List<int> { 10, 8 , 7, 9});


            teacher1.PrintUser(teacher1.Subjects);
            Console.WriteLine();

            teacher2.PrintUser(teacher2.Subjects);
            Console.WriteLine();

            student1.PrintUser(student1.Grades);
            Console.WriteLine();

            student2.PrintUser(student2.Grades);


            Console.ReadLine();

        }
    }
}
