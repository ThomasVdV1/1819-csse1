using System;

namespace Builder
{
    public abstract class Builder
    {
        public virtual void BuildPart () {
            Console.WriteLine("(Builder: ) Koffie maken ...");
        }
    }
}