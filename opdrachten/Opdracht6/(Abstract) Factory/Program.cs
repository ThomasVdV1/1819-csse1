using System;

namespace _Abstract__Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VormFactory vormFactory = new VormFactory();

            IVorm vormA = vormFactory.GetVorm("Cirkel");
            IVorm vormB = vormFactory.GetVorm("Vierkant");
            IVorm vormC = vormFactory.GetVorm("Rechthoek");
            IVorm vormD = vormFactory.GetVorm("Ruit");
            IVorm vormE = vormFactory.GetVorm("Trapezium");
            IVorm vormF = vormFactory.GetVorm("Parallellogram");

            vormA.Teken();
            vormB.Teken();
            vormC.Teken();
            vormD.Teken();
            vormE.Teken();
            vormF.Teken();
            
        }
    }
}
