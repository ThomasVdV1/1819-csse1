using System;

namespace lesweek7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Voertuig voertuig1 = new Voertuig();
            voertuig1.Laadvermogen = 12;
            Voertuig voertuig2 = new Voertuig(30);
        }
    }
}
