using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deel1: Menu

            string sorteren = "volgnummer";
            string sorteerType = "oplopend";

            Dictionary<string, double> toegewezenWaarden = new Dictionary<string, double>();

            List<string> menuItems = new List<string>();
            List<double> menuBedragen = new List<double>();

            toegewezenWaarden.Add("plat water", 1);
            toegewezenWaarden.Add("cola 25 cl", 1.5);
            toegewezenWaarden.Add("cola 33 cl", 2);
            toegewezenWaarden.Add("witte wijn", 3);
            toegewezenWaarden.Add("pils", 2);
            toegewezenWaarden.Add("toast", 5);
            toegewezenWaarden.Add("kaasplank", 4);
                    
            for (int i = 0; i < toegewezenWaarden.Count; i++)
            {
                menuItems.Add(toegewezenWaarden.Keys.ElementAt(i));
                menuBedragen.Add(toegewezenWaarden.Values.ElementAt(i));
            }

            Menu();
            ToonMenuItem();

            void Menu () {
                Console.WriteLine("Hoe wil je het menu sorteren? (volgnummer/naam/prijs)");
                sorteren = Console.ReadLine();
                Console.WriteLine("Hoe wil je het menu sorteren? (oplopend/aflopen)");
                sorteerType = Console.ReadLine();

                if (sorteren == "volgnummer")
                {
                    if (sorteerType == "oplopend")
                    {
                        for (int i = 0; i < toegewezenWaarden.Count; i++)
                        {
                            Console.WriteLine(toegewezenWaarden.ElementAt(i).Key + " : " + toegewezenWaarden.ElementAt(i).Value);
                        }
                    } 
                    else
                    {
                        for (int i = toegewezenWaarden.Count - 1; i > -1 ; i--)
                        {
                            Console.WriteLine(toegewezenWaarden.ElementAt(i).Key + " : " + toegewezenWaarden.ElementAt(i).Value);
                        }
                    }

                } 
                else if (sorteren == "naam")
                {
                    menuItems.Sort();

                    if (sorteerType == "aflopend")
                    {
                        menuItems.Reverse();
                    }

                    for (int i = 0; i < menuItems.Count; i++)
                    {
                        Console.WriteLine(menuItems[i] + " : " + toegewezenWaarden[menuItems[i]]);
                    }
                } 
                else if (sorteren == "prijs")
                {
                    menuBedragen.Sort();

                    
                    if (sorteerType == "aflopend")
                    {
                        menuBedragen.Reverse();
                    }

                    List<string> keys = new List<string>();

                    for (int i = 0; i < menuBedragen.Count; i++)
                    {

                        for (int j = 0; j < toegewezenWaarden.Count; j++)
                        {
                            if (toegewezenWaarden.ElementAt(j).Value == menuBedragen[i] 
                            && !keys.Contains(toegewezenWaarden.ElementAt(j).Key))
                            {
                                keys.Add(toegewezenWaarden.ElementAt(j).Key);
                            }    
                        }

                        Console.WriteLine(keys[i] + " : " + menuBedragen[i]);
                    }
                }
            }

            void ToonMenuItem () {
                Console.WriteLine("Aan de hand van wat wil je een menu-item opzoeken? (volgnummer/naam)");
                string input1 = Console.ReadLine();
                if (input1 == "volgnummer")
                {
                    Console.WriteLine("Aan de hand van welk volgnummer wil je een menu-item opzoeken?");
                    int inputVolgnummer = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (inputVolgnummer > -1 && inputVolgnummer < toegewezenWaarden.Count)
                    {
                        Console.WriteLine(toegewezenWaarden.ElementAt(inputVolgnummer).Key 
                        + " : " + toegewezenWaarden.ElementAt(inputVolgnummer).Value);
                    }
                }
                else if (input1 == "naam")
                {
                    Console.WriteLine("Welk menu-item wil je opzoeken?");
                    string inputNaam = Console.ReadLine();
                    Console.WriteLine(inputNaam + " : " + toegewezenWaarden[inputNaam]);
                }
            }


            // Deel 2: Wachtrij

            List<string> wachtrij = new List<string>();
            
            InputVerwerken();

            void InputVerwerken() {
                Console.WriteLine("Druk typ 's' voor de status van de wachtrij weer te geven, '+' om iets te bestellen en '-' om een een bestelling af te handelen");
                string input2 = Console.ReadLine();

                if (input2 == "s")
                {
                    for (int i = 0; i < wachtrij.Count; i++)
                    {
                        Console.WriteLine((i + 1) + " : " + wachtrij[i]);
                    }

                    InputVerwerken();
                }
                else if (input2 == "+")
                {
                    Console.WriteLine("Wat wil je bestellen?");
                    wachtrij.Add(Console.ReadLine());
                    InputVerwerken();
                }
                else if (input2 == "-")
                {
                    wachtrij.RemoveAt(0);
                    InputVerwerken();
                }
            }

        }
    }
}
