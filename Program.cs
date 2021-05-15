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
            Console.WriteLine(obj1.Assembly);

            obj1.FristName = "Tawhid";
            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj1.UpperCaseName());
            Console.WriteLine("Hello World!");
            Console.WriteLine("________________________________________________________________");

            B obj2 = new B();
            obj2.PrintMgs();
            D obj3 = new D();
            obj3.PrintMgs();




        }
    }
}
