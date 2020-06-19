using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsAndExtensions.Models
{
    public class PetStoreGenericDb<T> where T : Pet
    {
        private List<T> Db;

        public PetStoreGenericDb()
        {
            Db = new List<T>();
        }

        public void PrintPets()
        {
            foreach (var item in Db)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public void AddPet(T item)
        {
            Db.Add(item);
            Console.WriteLine($"Pet was added in the {item.GetType().Name} Db!");
        }

        public void BuyPet(string name)
        {
            T item = Db.FirstOrDefault(x => x.Name == name);
            if (item == null)
            {
                Console.WriteLine($"This pet was not found!");
                return;
            }
            Db.Remove(item);
            Console.WriteLine($"You have successully bought this pet from {item.GetType().Name} Db!");
        }

    }
}
