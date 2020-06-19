using System;
using System.Collections.Generic;

namespace GenericsAndExtensions.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public List<string> FavoriteFood { get; set; } = new List<string>();

        public override string PrintInfo()
        {
            return $"{Name} is a dog of type {Type} and is {Age} years old.";
        }

    }
}
