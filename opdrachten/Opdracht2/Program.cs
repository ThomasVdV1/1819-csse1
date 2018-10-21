using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faculteit

            Console.WriteLine("Van welk nummer wil je de faculteit berekenen?");
            int a = Convert.ToInt32(Console.ReadLine());
            
            int fac = a;

            while (a > 2)
            {
                a--;
                fac *= a;
            }

            Console.WriteLine("De faculteit van " + a + " is: " + fac);


            //Fibonacci

            Console.WriteLine("Hoeveel elementen van Fibonacci wil je berekenen?");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int fib = 1;

            Console.WriteLine("-----");

            if (b > 0)
            {
                Console.WriteLine("0");
                if (b > 1)
                {
                    Console.WriteLine("1");
                }
            }

            for (int i = 0; i < b - 2; i++)
            {
                int temp = c;
                c = fib;
                fib += temp;

                Console.WriteLine(fib);
            }
        
        }
    }
}
