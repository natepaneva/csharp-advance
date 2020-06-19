using System;
namespace GenericsAndExtensions.Models
{
    public class Cat : Pet
    {
        public bool  IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public override string PrintInfo()
        {
            return $"{Name} is a cat of type {Type} and is has {LivesLeft} left";
        }
    }
}
