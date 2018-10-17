using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int resultaat = 
            Optellen(Optellen(Vermenigvuldigen(Optellen(100, 7), 3), Vermenigvuldigen(Delen(Optellen(406, 7367), 69), 5)), 
            Optellen(Aftrekken(Vermenigvuldigen(73, 41), 39), Aftrekken(Vermenigvuldigen(7, 8), 19)));

            Console.WriteLine("Het resultaat is: " + resultaat);

            if (resultaat == 3872)
            {
                Console.WriteLine("Het resultaat is correct");
            } 
            else if (resultaat > 3872)
            {
                Console.WriteLine("Resultaat is te hoog");
            }
            else
            {
                Console.WriteLine("Resultaat is te laag");
            }



            int Optellen (int _a, int _b) {
                return _a + _b;
            }

            int Aftrekken (int _a, int _b) {
                return _a - _b;
            }

            int Vermenigvuldigen (int _a, int _b) {
                return _a * _b;
            }

            int Delen (int _a, int _b) {
                return _a / _b;
            }



            // Alle tafels:

            // for (int i = 0; i < 11; i++)
            // {
            //     for (int j = 0; j < 11; j++)
            //     {
            //         Console.WriteLine(i + " x " + j + " = " + i*j);
            //     }
            // }


            // Specifieke tafel:

            Tafel(9);

            void Tafel (int getal) 
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(getal + " x " + i + " = " + (getal * i)); 
                }
            }



            int getal3 = 3;
            do
            {
                //Word zowiezow uitgevoerd:

                Console.WriteLine("De waarde van het getal is :" + getal3);
                getal3++;
            } while (getal3 < 5);


            int getal4 = 3;
            while (getal4 < 5)
            {
                Console.WriteLine("De waarde van het getal is :" + getal4);
                getal4++;
            }

            
        }
    }
}
