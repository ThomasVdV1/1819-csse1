using System;

namespace Builder
{
    public class Frappemachine : Koffiemachine
    {
        private Koffie k = new Frappe();
        public override void AddIngredients() {
            Console.WriteLine("Frappe: stap 1 ...");
            Console.WriteLine("Frappe: stap 2 ...");
            Console.WriteLine("Frappe: stap 3 ...");
            Console.WriteLine("Frappe: stap 4 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}