using System;

namespace Builder
{
    public class Americano: Koffie
    {
        public override void Test() {
            Console.WriteLine("Americano klaar!");
        }
    }
}