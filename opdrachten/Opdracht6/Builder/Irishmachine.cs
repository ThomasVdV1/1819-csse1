using System;

namespace Builder
{
    public class Irishmachine : Koffiemachine
    {
        private Koffie k = new Irish();
        public override void AddIngredients() {
            Console.WriteLine("Irish: stap 1 ...");
            Console.WriteLine("Irish: stap 2 ...");
        }

        public override Koffie GetKoffie() {
            return k;
        }
    }
}