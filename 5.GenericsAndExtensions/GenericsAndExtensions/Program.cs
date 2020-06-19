using System;
using System.Collections.Generic;
using GenericsAndExtensions.Models;

namespace GenericsAndExtensions
{
    class Program
    {
        public static PetStoreGenericDb<Dog> DogDb = new PetStoreGenericDb<Dog>();
        public static PetStoreGenericDb<Cat> CatDb = new PetStoreGenericDb<Cat>();
        public static PetStoreGenericDb<Fish> FishDb = new PetStoreGenericDb<Fish>();

        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.WriteLine("Pets added to the base:");
            DogDb.AddPet(new Dog() { Name = "Toto", Type = "maltese", Age = 6, GoodBoi = false, FavoriteFood = { "meat", "cucumbers" } });
            DogDb.AddPet(new Dog() { Name = "Bruno", Type = "poodle", Age = 15, GoodBoi = true, FavoriteFood = { "meat", "bisquits" } });

            CatDb.AddPet(new Cat() { Name = "Misha", Type = "persian", Age = 10, IsLazy = true, LivesLeft = 6 });
            CatDb.AddPet(new Cat() { Name = "Luna", Type = "persian", Age = 5, IsLazy = true, LivesLeft = 3 });

            FishDb.AddPet(new Fish() { Name = "Nemo", Type = "clownfish", Age = 4, Color = "orange and white", Size = "small" });
            FishDb.AddPet(new Fish() { Name = "Dory", Type = "blue tang", Age = 4, Color = "blue and yellow", Size = "small" });

            Console.WriteLine();
            Console.WriteLine("Status of the pets you want to buy:");
            DogDb.BuyPet("Bruno");
            CatDb.BuyPet("Misha");

            Console.WriteLine();
            Console.WriteLine("List of the currect pets available:");
            DogDb.PrintPets();
            CatDb.PrintPets();
            FishDb.PrintPets();



            Console.ReadLine();

        }
    }
}
