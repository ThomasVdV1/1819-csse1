using System;

namespace Builder
{
    public class Ristrettomachine : Koffiemachine
    {
        private Koffie k = new Ristretto();
        public override void AddIngredients() {
            Console.WriteLine("Ristretto: stap 1 ...");
            Console.WriteLine("Ristretto: stap 2 ...");
            Console.WriteLine("Ristretto: stap 3 ...");
            Console.WriteLine("Ristretto: stap 4 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}