using System;

namespace Builder
{
    public class Macchiato: Koffie
    {
        public override void Test() {
            Console.WriteLine("Macchiato klaar!");
        }
    }
}