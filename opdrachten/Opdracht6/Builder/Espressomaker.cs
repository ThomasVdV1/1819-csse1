using System;

namespace Builder
{
    public class Espressomaker : Builder
    {
        public override void BuildPart() {
            Espresso e = new Espresso();
            Console.WriteLine("(Espresso:) Espresso maken ...");
            e.Test();
        }

        public void GetResult() {

        }
    }
}