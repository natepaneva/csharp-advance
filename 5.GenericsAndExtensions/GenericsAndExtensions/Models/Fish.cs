using System;
namespace GenericsAndExtensions.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override string PrintInfo()
        {
            return $"{Name} is a {Color} {Size} fish.";
        }
    }
}
