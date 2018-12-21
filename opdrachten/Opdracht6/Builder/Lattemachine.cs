using System;

namespace Builder
{
    public class Lattemachine : Koffiemachine
    {
        private Koffie k = new Latte();
        public override void AddIngredients() {
            Console.WriteLine("Latte: stap 1 ...");
            Console.WriteLine("Latte: stap 2 ...");
            Console.WriteLine("Latte: stap 3 ...");
            Console.WriteLine("Latte: stap 4 ...");
            Console.WriteLine("Latte: stap 5 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}