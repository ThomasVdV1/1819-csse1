using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Espressomaker em = new Espressomaker();
            em.BuildPart();
        }
    }
}
