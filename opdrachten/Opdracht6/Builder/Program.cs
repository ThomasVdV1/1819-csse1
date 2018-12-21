using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Koffiemachine koffiemachine;

            koffiemachine = new Espressomachine();
            director.MaakKoffie(koffiemachine);
            Koffie espresso = koffiemachine.GetKoffie();
            espresso.Test();

            koffiemachine = new Macchiatomachine();
            director.MaakKoffie(koffiemachine);
            Koffie macchiato = koffiemachine.GetKoffie();
            macchiato.Test();

            koffiemachine = new Ristrettomachine();
            director.MaakKoffie(koffiemachine);
            Koffie ristretto = koffiemachine.GetKoffie();
            ristretto.Test();

            koffiemachine = new Mochamachine();
            director.MaakKoffie(koffiemachine);
            Koffie mocha = koffiemachine.GetKoffie();
            mocha.Test();

            koffiemachine = new Irishmachine();
            director.MaakKoffie(koffiemachine);
            Koffie irish = koffiemachine.GetKoffie();
            irish.Test();

            koffiemachine = new Frappemachine();
            director.MaakKoffie(koffiemachine);
            Koffie frappe = koffiemachine.GetKoffie();
            frappe.Test();

            koffiemachine = new Lattemachine();
            director.MaakKoffie(koffiemachine);
            Koffie latte = koffiemachine.GetKoffie();
            latte.Test();

            koffiemachine = new Glacemachine();
            director.MaakKoffie(koffiemachine);
            Koffie glace = koffiemachine.GetKoffie();
            glace.Test();

            koffiemachine = new Americanomachine();
            director.MaakKoffie(koffiemachine);
            Koffie americano = koffiemachine.GetKoffie();
            americano.Test();

            koffiemachine = new Cappuccinomachine();
            director.MaakKoffie(koffiemachine);
            Koffie cappuccino = koffiemachine.GetKoffie();
            cappuccino.Test();
            
        }
    }
}
