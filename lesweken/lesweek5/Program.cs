using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {

            // string tekst = " Dit is een test               ";
            // string uppercase = tekst.ToUpper();
            // string lowercase = tekst.ToLower();
            // string[] woorden = tekst.Split(" ", StringSplitOptions.None);

            // Console.WriteLine(woorden.Length);

            // for (int i = 0; i < uppercase.Length; i++)
            // {
            //     Console.WriteLine(uppercase[i]);
            // }

            // for (int i = 0; i < lowercase.Length; i++)
            // {
            //     Console.WriteLine(lowercase[i]);
            // }

            // char[] spatie = {' '};
            // Console.WriteLine(uppercase.Trim(spatie));
            // Console.WriteLine(lowercase.Trim(spatie));

            // for (int i = 0; i < woorden.Length; i++)
            // {
            //     Console.WriteLine(woorden[i]);
            // }

            //RANDOM GETALLEN

            Random randomGetal = new Random();

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(randomGetal.Next(0,10));
            // }

            char[] chars = new Char[8];
            chars[0] = '0';
            chars[1] = 'G';
            //Char aangeroepen met behulp van integer waarde.
            chars[2] = (char)78;
            //Char aangeroepen door middel van de UNICODE van het karakter.
            chars[3] = '\u002E';

            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }

            char[] campus = {'M', 'A', 'R'};

            string[] menu1 = new string[3] ;
            menu1[0] = "broodje martino";
            menu1[1] = "broodje ham";
            menu1[2] = "broodje kaas";

            foreach (var item in menu1)
            {
                Console.WriteLine(item);
            }
            
            string[] menu2 = new string[3] {"broodje scampi", "broodje brie", "broodje boulet"};
            
            foreach (var item in menu2)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < menu2.Length; i++)
            {
                Console.WriteLine(menu2[i]);
            }

            string[,] menu3 = new string[,] {{"broodje scampi", "4"}, {"broodje brie", "3"}, {"broodje boulet", "5"}};
            foreach (var item in menu3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
