using System;

namespace Builder
{
    public class Latte: Koffie
    {
        public override void Test() {
            Console.WriteLine("Latte klaar!");
        }
    }
}