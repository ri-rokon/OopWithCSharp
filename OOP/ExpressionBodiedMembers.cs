using System;
using System.Collections.Generic;
using System.Text;

namespace OopWithCSharp.OOP
{
    class ExpressionBodiedMembers
    {
        private string Name;
        public ExpressionBodiedMembers(string fristName, string lastName) => Name = $"{fristName} {lastName}";

        public string UpperCaseName() => Name.ToUpper();

        public override string ToString() => GetType().Namespace;

        ~ExpressionBodiedMembers() => Console.WriteLine($"The {ToString()} destructor is executing.");

    }
}
