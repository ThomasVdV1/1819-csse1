using System;

namespace Builder
{
    public class Koffie
    {

        // private string koffieType;

        // public Koffie (string koffieType) {
        //     this.koffieType = koffieType;
        // }

        public virtual void Test() {
            Console.WriteLine("(IKoffie) Koffie klaar!");
        }
    }
}