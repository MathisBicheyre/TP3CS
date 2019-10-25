using System;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo vincennes = new Zoo();
            Cow cow1 = new Cow("cow 1");
            Cow cow2 = new Cow("cow 2");            
            string file = @"..\..\..\tmp\zoosave.out"; // chaine verbatim
            //string file = @"/tmp/zoosave.out"; // chaine verbatim
            vincennes.add(new Lion("lion 1"));            
            vincennes.add(cow1);            
            vincennes.add(new Lizard("lizard 1"));            
            vincennes.add(new Platypus("platypus 1"));            
            vincennes.add(new Snake("snake 1"));            
            vincennes.display(); // affiche type et nom des animaux
            vincennes.remove(cow1);            
            vincennes.remove(cow2);            
            vincennes.display();            
            vincennes.move(); // appelle move sur les animaux
            vincennes.eat(); // appelle eat sur les animaux
            vincennes.count();            
            vincennes.save(file);            
            vincennes.clear();            
            vincennes.display();            
            vincennes.load(file);            
            vincennes.display();            
            System.Console.Read();
        }
    }
}