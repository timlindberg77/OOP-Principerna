using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principerna.Klasser
{
    public class Animal
    {
        //Attributer för gundklassen
        public string Name { get; set; }
        public int Age { get; set; }
        //metoder
        public void makeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
