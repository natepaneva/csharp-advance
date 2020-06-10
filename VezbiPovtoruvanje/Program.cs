using System;
using System.Collections.Generic;

namespace VezbiPovtoruvanje
{
    class Program
    {

        static void Main(string[] args)
        {
            //EXERCISE 3 

            //Console.WriteLine("WELCOME");
            //Console.WriteLine("Press 1 to start the game or 3 to exit!");

            //string[] choices = new string[] { "rock", "paper", "sciccors" };
            //Random random = new Random();


            //double userScore = 0;
            //double computerScore = 0;

            //string input = Console.ReadLine();

            //while (true)
            //{
            //    if (input == "1")
            //    {
            //        Console.WriteLine("Pick r for rock, p for paper or s for scissors");
            //        string userChoice = Console.ReadLine();

            //        string computerChoice = random.Next(choices.Length).ToString();
            //        if (computerChoice == "0" && userChoice == "p")
            //        {
            //            userScore++;
            //            Console.WriteLine($"The computer choice is rock");
            //            Console.WriteLine("You won!");
            //        }
            //        if (computerChoice == "0" && userChoice == "s")
            //        {
            //            computerScore++;
            //            Console.WriteLine($"The computer choice is rock");
            //            Console.WriteLine("You lost :(!");

            //        }
            //        if (computerChoice == "1" && userChoice == "r")
            //        {
            //            computerScore++;
            //            Console.WriteLine($"The computer choice is paper");
            //            Console.WriteLine("You lost :(!");

            //        }
            //        if (computerChoice == "1" && userChoice == "s")
            //        {
            //            userScore++;
            //            Console.WriteLine($"The computer choice is paper");
            //            Console.WriteLine("You won!");

            //        }
            //        if (computerChoice == "2" && userChoice == "r")
            //        {
            //            userScore++;
            //            Console.WriteLine($"The computer choice is scissors");
            //            Console.WriteLine("You won!");

            //        }
            //        if (computerChoice == "2" && userChoice == "p")
            //        {
            //            computerScore++;
            //            Console.WriteLine($"The computer choice is scissors");
            //            Console.WriteLine("You lost :(!");

            //        }
            //        if (computerChoice == "0" && userChoice == "r")
            //        {
            //            Console.WriteLine($"The computer choice is rock");
            //            Console.WriteLine("It's a tie");

            //        }
            //        if (computerChoice == "1" && userChoice == "p")
            //        {
            //            Console.WriteLine($"The computer choice is paper");
            //            Console.WriteLine("It's a tie");

            //        }
            //        if (computerChoice == "2" && userChoice == "s")
            //        {
            //            Console.WriteLine($"The computer choice is scissors");
            //            Console.WriteLine("It's a tie");

            //        }

            //        Console.WriteLine("Press 1 to continue playing, 2 to stop and view the statistics and 3 to Exit");
            //        input = Console.ReadLine();
            //    }
            //    if (input == "2")
            //    {

            //        double total = userScore + computerScore;
            //        double userScorePersentage;
            //        double computerScorePersentage;
            //        if (userScore != 0)
            //        {
            //            userScorePersentage = Math.Round(userScore / total * 100, 2);
            //        }
            //        else
            //        {
            //            userScorePersentage = 0;
            //        }

            //        if (computerScore != 0)
            //        {
            //            computerScorePersentage = Math.Round(computerScore / total * 100, 2);
            //        }
            //        else
            //        {
            //            computerScorePersentage = 0;
            //        }


            //        Console.WriteLine($"The computer have won {computerScorePersentage}% of total games played!");
            //        Console.WriteLine($"You have won has {userScorePersentage}% of total games played!");

            //        Console.WriteLine("Press 1 to play again or and 3 to exit");
            //        userScore = 0;
            //        computerScore = 0;
            //        input = Console.ReadLine();

            //    }
            //    if (input == "3")
            //    {
            //        Console.WriteLine("Thanks for playing our game. Bye!");
            //        break;
            //    }

            //}

            //EXERCISE 2

            Console.WriteLine("Enter day in a forman mm/dd/yyyy");
            string date = Console.ReadLine();
            bool check = false;

            while (true)
            {
                DateTime convertedDate = DateTime.Parse(date);
                string weekday = convertedDate.ToString("dddd");

                string[] holidays = new string[] { "01/01", "01/07", "05/01", "05/25", "08/02", "09/08", "10/23", "12/08" };

                if (weekday == "Saturday" || weekday == "Sunday")
                {
                    Console.WriteLine($"It's a weekend day. Have fun!");
                }

                else
                {
                    foreach (var holiday in holidays)
                    {
                        if (date.Contains(holiday))
                        {
                            Console.WriteLine("It's a holiday. Enjoy!");
                            check = true; 
                            break;
                        }
                        
                    }
                    if (check == false)
                    {
                        Console.WriteLine("Sorry you have to work today :(");

                    }
                    check = false;

                }


                Console.WriteLine("Do you want to enter another date? Press n to exit.");
                date = Console.ReadLine().ToLower();

                if (date == "n")
                {
                    break;
                }
            }


            //EXERCISE 1

            //List<string> names = new List<string>();

            //Console.WriteLine("Enter how many names you like. If you want to stop enter x.");
            //string name = Console.ReadLine();
            //names.Add(name);

            //while (true)
            //{
            //    name = Console.ReadLine().ToLower();

            //    if (name == "x")
            //    {
            //        break;
            //    }
            //    names.Add(name);
            //}

            //Console.WriteLine("Now enter a text containing some of the names and we will display you how many time each name appears!");

            //string text = Console.ReadLine();
            //string[] words = text.Split(" ");

            //int counter = 0;
            //foreach (var singlename in names)
            //{
            //    foreach (var item in words)
            //    {
            //        if (singlename.ToLower() == item.ToLower())
            //        {
            //            counter++;
            //        }
            //    }
            //    Console.WriteLine($"{singlename} is shown {counter} times");
            //    counter = 0;
            //}


            Console.ReadLine();


        }
    }
}
