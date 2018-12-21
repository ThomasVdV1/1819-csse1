using System;

namespace Builder
{
    public class Espressomachine : Koffiemachine
    {
        private Koffie k = new Espresso();
        public override void AddIngredients() {
            Console.WriteLine("Espresso: stap 1 ...");
            Console.WriteLine("Espresso: stap 2 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}