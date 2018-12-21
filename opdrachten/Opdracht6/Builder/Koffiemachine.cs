using System;

namespace Builder
{
    public abstract class Koffiemachine
    {
        public virtual void AddIngredients () {
            Console.WriteLine("(Builder: ) Koffie maken ...");
        }

        public virtual Koffie GetKoffie () {
            return null;
        }
    }
}