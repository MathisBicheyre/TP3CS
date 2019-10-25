using System;

namespace TP3
{
    [Serializable]
    public class Lion: IMammal
    {
        public Lion(string name)
        {
            Name = name;
        }

        public void be_mammal()
        {
            System.Console.WriteLine("I am mammal lion");
        }

        public string Name { get; set; }
        public void move()
        {
            Console.WriteLine(Name + " runs");
        }

        public void eat()
        {
            Console.WriteLine(Name + " eats other mammals");
        }
    }
}