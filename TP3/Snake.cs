using System;

namespace TP3
{
    [Serializable]
    public class Snake: IReptile
    {
        public Snake(string name)
        {
            Name = name;
        }
        
        public void lay_eggs()
        {
            System.Console.WriteLine("Bigger plop");
            
        }

        public string Name { get; set; }
        public void move()
        {
            Console.WriteLine(Name + " is crawling");
        }

        public void eat()
        {
            Console.WriteLine(Name + " eats a man");
        }
    }
}