using System;

namespace TP3
{
    [Serializable]
    public class Lizard: IReptile
    {
        public Lizard(string name)
        {
            Name = name;
        }
        
        public void lay_eggs()
        {
            System.Console.WriteLine("Small plop");
            
        }

        public string Name { get; set; }
        public void move()
        {
            Console.WriteLine(Name + " is crawling");
        }

        public void eat()
        {
            Console.WriteLine(Name + " is eating bugs");
        }
    }
}