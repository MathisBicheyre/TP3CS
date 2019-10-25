using System.Collections;

namespace TP3
 {
     public interface IAnimal
     {
         string Name { get; set; }

         void move();
         void eat();
     }
 }