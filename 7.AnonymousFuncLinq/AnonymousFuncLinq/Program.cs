using System;
using System.Collections.Generic;
using System.Linq;
using AnonymousFuncLinq.Helpers;
using AnonymousFuncLinq.Models;

namespace AnonymousFuncLinq
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("============================================================================");
            Console.WriteLine("1.All persons first names that starts with R ordered by age with descending order:");
            Console.WriteLine("a)Using LINQ");
            List<string> firstNameWithRByAgeLinq = DB.people.Where(x => x.FirstName.StartsWith("R"))
                                                            .OrderByDescending(x => x.Age)
                                                            .Select(x => x.FirstName)
                                                            .ToList();

            firstNameWithRByAgeLinq.ForEach(Console.WriteLine);


            Console.WriteLine("b)Using SQL");
            List<string> firstNameWithRByAgeSql = (from x in DB.people
                                                   where x.FirstName.StartsWith("R")
                                                   orderby x.Age descending
                                                   select x.FirstName)
                                                   .ToList();

            firstNameWithRByAgeSql.ForEach(Console.WriteLine);

            Console.WriteLine("============================================================================");
            Console.WriteLine("2.All brown dogs names and ages that are older than 3 years, ordered by age:");
            Console.WriteLine("1)Using LINQ");
            List<string> brownDogsOlderThan3yearsLinq = DB.dogs.Where(x => x.Color == "Brown")
                                                      .Where(x => x.Age > 3)
                                                      .OrderBy(x => x.Age)
                                                      .Select(x => $"{x.Name} {x.Age}")
                                                      .ToList();

            brownDogsOlderThan3yearsLinq.ForEach(Console.WriteLine);

            Console.WriteLine("b)Using SQL");
            List<string> brownDogsOlderThan3yearsSql = (from x in DB.dogs
                                                        where x.Color == "Brown"
                                                        where x.Age > 3
                                                        orderby x.Age
                                                        select $"{x.Name} {x.Age}")
                                                        .ToList();

            brownDogsOlderThan3yearsSql.ForEach(Console.WriteLine);


            Console.WriteLine("============================================================================");
            Console.WriteLine("3.All persons with more that 2 dogs, ordered by name by descending order:");
            Console.WriteLine("1)Using LINQ");
            List<string> personsWith2DogsByNameLinq = DB.people.Where(x => x.Dogs.Count() > 2)
                                                                .OrderByDescending(x => x.FirstName)
                                                                .Select(x=>x.FirstName)
                                                                .ToList();

            personsWith2DogsByNameLinq.ForEach(Console.WriteLine);

            Console.WriteLine("b)Using SQL");
            List<string> personsWith2DogsByNameSql = (from x in DB.people
                                                      where x.Dogs.Count() > 2
                                                      orderby x.FirstName descending
                                                      select x.FirstName)
                                                      .ToList();

            personsWith2DogsByNameSql.ForEach(Console.WriteLine);

            Console.WriteLine("============================================================================");
            Console.WriteLine("4.All Freddy's dogs names older than 1 year:");
            Console.WriteLine("1)Using LINQ");
            List<List<string>> freddysDogsOlderThan1YearLinq = DB.people.Where(x => x.FirstName == "Freddy")
                                                                    .Select(x => x.Dogs.Where(y => y.Age > 1).Select(x => x.Name).ToList())
                                                                    .ToList();

            freddysDogsOlderThan1YearLinq.ForEach(x => x.PrintItems());

            Console.WriteLine("b)Using SQL");

            List<List<Dog>> freddysDogsOlderThan1YearSql = (from x in DB.people
                                                            where x.FirstName == "Freddy"
                                                            where (from y in x.Dogs
                                                                   where y.Age > 1
                                                                   select y.Name).ToList().Count() != 0
                                                            select x.Dogs).ToList();


            foreach (var items in freddysDogsOlderThan1YearSql)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item.Name);
                }
            }



            //freddysDogsOlderThan1YearSql.ForEach(x => x.PrintItems());


            Console.WriteLine("============================================================================");
            Console.WriteLine("5.Print Nathen's first dog.");
            Console.WriteLine("1)Using LINQ");
            string nathansFirstDogLinq = DB.people.Where(x => x.FirstName == "Nathen")
                                            .Select(x => x.Dogs).FirstOrDefault().Select(x=>x.Name).FirstOrDefault();

            Console.WriteLine(nathansFirstDogLinq);

            Console.WriteLine("b)Using SQL");
            List<Dog> nathansFirstDogSql = (from x in DB.people
                                      where x.FirstName == "Nathen"
                                      select x.Dogs).FirstOrDefault();

            string firstSql = nathansFirstDogSql.Select(x=>x.Name).FirstOrDefault();
            Console.WriteLine(firstSql);


            Console.WriteLine("============================================================================");
            Console.WriteLine("6.All white dogs name from Christopher, Freddy, Erin and Amelia order by name:");
            Console.WriteLine("1)Using LINQ");

            List<List<string>> whiteDogs = DB.people.Where(x => x.FirstName == "Cristofer" && x.FirstName == "Freddy"  && x.FirstName == "Erin" && x.FirstName == "Amelia")
                                     .Select(x => x.Dogs.Where(y => y.Color == "white").Select(x => x.Name).ToList())
                                     .ToList();

            whiteDogs.ForEach(x => x.PrintItems());

            //foreach (var items in whiteDogs)
            //{
            //    foreach (var item in items)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            Console.WriteLine("b)Using SQL");


            Console.ReadLine();
        }
    }
}
