using System;
using System.Collections.Generic;
using System.Text;

namespace OopWithCSharp.OOP
{
    public class A
    {
        private readonly int value = 10;
        public virtual void PrintMgs()
        {
            Console.WriteLine("Class virtual A ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Class virtual A ");
        }


        public class Nested : A
        {
            public int GetValue()
            {
                return this.value;
            }

        }
    }
}
