using System;

namespace Builder
{
    public class Cappuccino: Koffie
    {
        public override void Test() {
            Console.WriteLine("Cappuccino klaar!");
        }
    }
}