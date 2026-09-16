using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principerna.Klasser
{
    //abstraction - Använd en abstract klass och arv
    public abstract class Hund : Animal //bastrakt klass som ärver från Animal klassen
    {
        public abstract void Kommand(); //abstrakt metod som måste implementeras i subklasserna
    }

    public class Vildhund : Hund 
    {
        public override void Kommand()
        {
            Console.WriteLine("Hunden lyssnade inte");
        }
    }

    public class TamHund : Hund
    {
        public override void Kommand()
        {
            Console.WriteLine("Hunden lyssnade");
        }
    }
}
