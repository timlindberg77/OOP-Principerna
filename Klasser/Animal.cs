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

        public int Hunger //public attribut för encapsulation
        {
            get { return hunger; }
            set { hunger = value; }
        }

        private int hunger = 5;  //private attributer för encapsulation med ett startvärde på 5
        //metoder
        public virtual void makeSound()
        {
            Console.WriteLine("Animal sound");
        }
        public void Feed(int amount) // en metod för att mata djuret och minska hungernivån
        {
            hunger -= amount;
            Console.WriteLine($"{Name} har blivit matad. Hungernivå: {hunger}");
        }
    }
}
