using System;

namespace Builder
{
    public class Mocha: Koffie
    {
        public override void Test() {
            Console.WriteLine("Mocha klaar!");
        }
    }
}