using System;
using System.Collections;

namespace TP3
{
    [Serializable]
    public class Cow: IMammal
    {
        public string Name { get; set; }
        
        public Cow(string name)
        {
            Name = name;
        }

        public void be_mammal()
        {
            System.Console.WriteLine("I am mammal cow");
        }
        
        public void move()
        {
           Console.WriteLine(Name + " is just here");
        }

        public void eat()
        {
            Console.WriteLine(Name + " eats grass");
        }
        
    }
}