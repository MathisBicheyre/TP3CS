using System;

namespace TP3
{
    [Serializable]
    public class Platypus: IMammal
    {
        public Platypus(string name)
        {
            Name = name;
        }

        public void be_mammal()
        {
            System.Console.WriteLine("I am mammal platypus");
        }

        public string Name { get; set; }
        public void move()
        {
            Console.WriteLine(Name + " is moving weirdly");
        }

        public void eat()
        {
            Console.WriteLine(Name + " is eating things");
        }
    }
}