using OopWithCSharp.OOP;
using System;

namespace OopWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionBodiedMembers obj1 = new ExpressionBodiedMembers("Ridwanul", "Isalm");
            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj1.UpperCaseName());
            Console.WriteLine("Hello World!");
        }
    }
}
