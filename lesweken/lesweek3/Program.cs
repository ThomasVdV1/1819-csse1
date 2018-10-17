using System;

namespace lesweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            // Initialisere: een startwaarde geven
            // int c, d;
            int a = 100;
            int b = 7;
            int c = a + b;
            int d = 3;
            int e = c * d;
            
            int f = 406;
            int g = 7367;
            int h = f + g;
            int i = 69;
            int j = h / i;
            int k = 5;
            int l = j * k;

            int m = 73;
            int n = 41;
            int o = m * n;
            int p = 39;
            int q = o - p;

            int r = 7;
            int s = 8;
            int t = 7 * 8;
            int u = 19;
            int v = t - u;

            int w = e + l + q + v;

            Console.WriteLine("Het resultaat is: " + w);

            // Rekenmachine
            int resultaat1 = optellen(a, b);
            int resultaat2 = delen(a, b);
            int resultaat3 = verhogen(a);

            
        }

        static int optellen (int a, int b) {
            return a + b;
        }

        static int delen (int a, int b) {
            return a / b;
        }

        static int verhogen (int a) {
            return a++;
        }
    }
}
