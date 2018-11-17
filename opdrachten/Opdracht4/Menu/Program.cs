using System;
using System.Collections.Generic;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menuitem> menu = new List<Menuitem>();
            
            Menuitem ledigItem1 = new Menuitem();
            Menuitem taart = new Menuitem("Taart", "Dessert", "Euro", 3.99);
            Menuitem enkelPrijs= new Menuitem(9.99);
            Menuitem soep = new Menuitem("Soep", "Voorgerecht", "Euro", 2);
            Menuitem ledigItem2 = new Menuitem();
            Menuitem pizza = new Menuitem("Pizza", "Hoofdgerecht", "Dollar", 5.49);
            Menuitem ijsje = new Menuitem("Ijsje", "Dessert", 4.49);
            Menuitem drogeBoterham = new Menuitem("Droge boterham", "Ontbijt", "Gulden", 8.80);
            Menuitem broodjeSpaghetti = new Menuitem("Broodje Spaghetti", 0.18);
            Menuitem frieten = new Menuitem("Frieten","Hoofdgerecht", 0.18);

            menu.Add(ledigItem1);
            menu.Add(taart);
            menu.Add(enkelPrijs);
            menu.Add(soep);
            menu.Add(ledigItem2);
            menu.Add(pizza);
            menu.Add(ijsje);
            menu.Add(drogeBoterham);
            menu.Add(broodjeSpaghetti);
            menu.Add(frieten);

            foreach (Menuitem m in menu)
            {
                Console.WriteLine(m.ToString());
            }

            

            /*
            VRAGEN:

            - "Prijs" is in dit geval de basisklasse, "Product" is een subklasse van "Prijs", 
               en "MenuItem" is een subklasse van "Product".

            - Ofwel door gebruik te maken van "menu.Sort()" (om op de naam van het Menuitem te sorteren), 
              ofwel door gebruik te maken van een functie/methode en/of tijdelijke lijst.

            */
        }
    }
}
