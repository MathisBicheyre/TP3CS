using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TP3
{
    [Serializable]
    public class Zoo
    {
        public List<IAnimal> Animals { get; set; }

        private int _nb;

        public int Nb
        {
            get => _nb;
            set => _nb = value;
        }

        public Zoo()
        {
           Animals = new List<IAnimal>();
           _nb = 0;
        }

        public void add(IAnimal animal)
        {
            Animals.Add(animal);
            _nb++;
        }

        public void remove(IAnimal animal)
        {
            Animals.Remove(animal);
            _nb--;
        }

        public void eat()
        {
            Animals.ForEach(animal => animal.eat());
        }

        public void move()
        {
            Animals.ForEach(animal => animal.move());
        }

        public void count()
        {
            int mammal=0;
            foreach (IAnimal animal in Animals)
            {
                if (animal is IMammal)
                    mammal++;
            }
            
            Console.WriteLine("The zoo has " + _nb + " animals");
            Console.WriteLine("There are " + mammal + " mammals and " + (_nb-mammal) + " reptiles");
        }

        public void display()
        {
            Console.WriteLine("Le zoo contient :");
            Console.WriteLine("−−−−−−−−DEBUT−−−−−−−−−−−−−−−−−−−");
            foreach (var animal in Animals)
            {
                if (animal is IMammal)
                    Console.WriteLine("Mammal " + animal.Name);
                else
                    Console.WriteLine("Reptile " + animal.Name);
            }
            Console.WriteLine("−−−−−−−−FIN−−−−−−−−−−−−−−−−−−−−−");
        }

        public void clear()
        {
            _nb = 0;
            Animals.Clear();
        }

        public void save(string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            
            if(File.Exists(path))
                File.Delete(path);

            FileStream fs = File.Create(path);

            bf.Serialize(fs, this);
            
            fs.Close();
        }

        public void load(string path)
        {
            Zoo lz = new Zoo();
            BinaryFormatter bf = new BinaryFormatter();

            if(File.Exists(path))
            {
                FileStream fs;
                fs = File.Open(path, FileMode.Open, FileAccess.Read);
                
                try  
                {  
                    using (fs)  
                    {  
                        this.clear();
                        lz = (Zoo) bf.Deserialize(fs);
                        
                        foreach (IAnimal animal in lz.Animals)
                        {
                            this.add(animal);
                        }
                    }  
                }  
                catch  
                {  
                    throw new InvalidDataException(); 
                }
            }
            else
            {
                throw new FileLoadException();
            }
        }
    }
}