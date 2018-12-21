using System;

namespace Builder
{
    public class Americanomachine : Koffiemachine
    {
        private Koffie k = new Americano();
        public override void AddIngredients() {
            Console.WriteLine("Americano: stap 1 ...");
            Console.WriteLine("Americano: stap 2 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}