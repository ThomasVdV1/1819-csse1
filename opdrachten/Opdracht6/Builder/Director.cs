using System;

namespace Builder
{
    public class Director
    {
        public void MaakKoffie (Koffiemachine koffiemachine) {
            koffiemachine.AddIngredients();
        }
    }
}