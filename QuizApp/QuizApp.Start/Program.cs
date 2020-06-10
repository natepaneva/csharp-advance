using System;
using QuizApp.Domain.User;
using QuizApp.Services;

namespace QuizApp.Start
{
    class Program
    {
        private static UserService _userService = new UserService();
        private static User _loggedUser = new User();

        static void Main(string[] args)
        {
            Console.WriteLine("LOG IN");
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            int grade = 0;

            while (true)
            {

                _loggedUser = _userService.LogIn(username, password);
                if (_loggedUser == null)
                {
                    Console.WriteLine("Username/password incorrect");

                    Console.WriteLine("Enter username:");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    password = Console.ReadLine();
                    _loggedUser = _userService.LogIn(username, password);


                    if (_loggedUser == null)
                    {
                        Console.WriteLine("Username/password incorrect");

                        Console.WriteLine("Enter username:");
                        username = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        password = Console.ReadLine();
                        _loggedUser = _userService.LogIn(username, password);

                        if (_loggedUser == null)
                        {
                            Console.WriteLine("Try again in 30 minutes.");
                            break;
                        }
                    }
                }
                if (_loggedUser.Role == Role.Student)
                {
                    if (_loggedUser.TookTest == true)
                    {
                        Console.WriteLine("You have already took the test!");
                        
                    }
                    else
                    {
                        Console.WriteLine("Welcome student. Answer the following question by submiting the number of your choice:");
                        Console.WriteLine("Q: What is the capital of Tasmania? \n1: Dodoma \n2: Hobart \n3: Launceston \n4: Wellington");
                        int answer1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Q: What is the tallest building in the Republic of the Congo? \n1: Kinshasa Democratic Republic of the Congo Temple \n2:  Palais de la Nation * \n3: Kongo Trade Centre \n4: Nabemba Tower");
                        int answer2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Q: Which of these is not one of Pluto's moons? \n1: Styx \n2: Hydra \n3: Nyx \n4: Lugia");
                        int answer3 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Q: What is the smallest lake in the world? \n1: Onega Lake \n2: Benxi Lake  \n3: Kivu Lake \n4: Wakatipu Lake");
                        int answer4 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Q: What country has the largest population of alpacas \n1: Chad \n2: Peru \n3: Australia \n4: Niger");
                        int answer5 = Int32.Parse(Console.ReadLine());

                        _loggedUser.TookTest = true;

                        if (answer1 == 2) grade++;
                        if (answer2 == 4) grade++;
                        if (answer3 == 3) grade++;
                        if (answer4 == 2) grade++;
                        if (answer5 == 2) grade++;

                        Console.WriteLine($"Your score is {grade}/5.");
                        _loggedUser.Grade = grade;
                        _loggedUser.TookTest = true;
                        grade = 0;
                        Console.WriteLine("LOGED OUT");
                    }
                }
                if (_loggedUser.Role == Role.Teacher)
                {
                    Console.WriteLine("Welcome teacher");
                    _userService.Grades(_userService.Users);
                    Console.ReadLine();
                    
                }

                Console.WriteLine("LOG IN");
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

            }
        }
    }
}
