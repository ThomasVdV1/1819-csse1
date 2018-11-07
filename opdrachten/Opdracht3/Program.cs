using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            AlleTafels();

            Console.WriteLine("Van welk getal wil je de tafels berekenen?");
            SpecifiekeTafels(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Van welk nummer wil je de faculteit berekenen?");
            Faculteit(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Hoeveel elementen van Fibonacci wil je berekenen?");
            Fibonacci(Convert.ToInt32(Console.ReadLine()));

            
            //Tafels van vermenigvuldiging

            void AlleTafels () {
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        Console.WriteLine(i + " x " + j + " = " + i*j);
                    }
                }
            }

            void SpecifiekeTafels(int tafel){
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(tafel + " x " + i + " = " + tafel*i);
                }
            }
            


            //Faculteit

            void Faculteit(int a) {
                int aa = a;
                
                int fac = a;

                while (a > 2)
                {
                    a--;
                    fac *= a;
                }

                Console.WriteLine("De faculteit van " + aa + " is: " + fac);
            }
            


            //Fibonacci

            void Fibonacci(int b) {
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
}
