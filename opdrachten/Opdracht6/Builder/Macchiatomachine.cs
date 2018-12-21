using System;

namespace Builder
{
    public class Macchiatomachine : Koffiemachine
    {
        private Koffie k = new Macchiato();
        public override void AddIngredients() {
            Console.WriteLine("Macchiato: stap 1 ...");
            Console.WriteLine("Macchiato: stap 2 ...");
            Console.WriteLine("Macchiato: stap 3 ...");
            Console.WriteLine("Macchiato: stap 4 ...");
            Console.WriteLine("Macchiato: stap 5 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}