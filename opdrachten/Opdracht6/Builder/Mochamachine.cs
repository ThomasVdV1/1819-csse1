using System;

namespace Builder
{
    public class Mochamachine : Koffiemachine
    {
        private Koffie k = new Mocha();
        public override void AddIngredients() {
            Console.WriteLine("Mocha: stap 1 ...");
            Console.WriteLine("Mocha: stap 2 ...");
            Console.WriteLine("Mocha: stap 3 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}