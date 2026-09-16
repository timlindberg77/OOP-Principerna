using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principerna.Klasser
{
    public class Tiger : Animal //skapar en inheritance baserat på animal klassen 
    {
        public override void makeSound() //override metoden för att ändra ljudet som tigrar gör
        {
            Console.WriteLine("Tiger roars");
        }
    }
}
