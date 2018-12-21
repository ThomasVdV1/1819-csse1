using System;

namespace Builder
{
    public class Glacemachine : Koffiemachine
    {
        private Koffie k = new Glace();
        public override void AddIngredients() {
            Console.WriteLine("Glace: stap 1 ...");
            Console.WriteLine("Glace: stap 2 ...");
            Console.WriteLine("Glace: stap 3 ...");
            Console.WriteLine("Glace: stap 4 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}