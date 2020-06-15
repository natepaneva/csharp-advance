using System;
using System.Collections.Generic;
using StaticClassesPolymorohism.Models;

namespace StaticClassesPolymorohism.DB
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();
        public static List<Dog> ValidateDogs;

        static DogShelter()
        {
            ValidateDogs = new List<Dog>
            {
               new Dog (1, "Toto", "White"),
               new Dog (2, "Roki", "Black"),
               new Dog (2, "R")
            };
        }

        public static void Check()
        {
            foreach (var dog in ValidateDogs)
            {
                Validate(dog);
            }
        }

        public static void Validate(Dog dog)
        {

            bool validated;

            if (dog.Id > 0 && dog.Name != null && dog.Name.Length >= 2 && dog.Color != null)
            {
                validated = true;
            }
            else
            {
                validated = false;
            }
           

            if (validated == true)
            {
                Console.WriteLine("Validated");
                Dogs.Add(dog);
            }
            else
            {
                Console.WriteLine("There is something wrong!");
            }

           
        }

        public static void PrintAll()
        {
            Console.WriteLine("The list of validated dogs is:");
            int i = 1;
            foreach (var dog in Dogs)
            {
                Console.WriteLine($"{i}. {dog.Name}");
                i++;
            }
        }
    }
}
