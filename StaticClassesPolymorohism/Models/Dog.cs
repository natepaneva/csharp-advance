using System;
namespace StaticClassesPolymorohism.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public object Validate { get; internal set; }

        public void Bark()
        {
            Console.WriteLine("Bark, Bark");
        }


        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public Dog(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
