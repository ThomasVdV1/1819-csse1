using System;

namespace Builder
{
    public class Cappuccinomachine : Koffiemachine
    {
        private Koffie k = new Cappuccino();
        public override void AddIngredients() {
            Console.WriteLine("Cappuccino: stap 1 ...");
            Console.WriteLine("Cappuccino: stap 2 ...");
            Console.WriteLine("Cappuccino: stap 3 ...");
            Console.WriteLine("Cappuccino: stap 4 ...");
            Console.WriteLine("Cappuccino: stap 5 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}