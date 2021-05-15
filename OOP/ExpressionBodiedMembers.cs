using System;
using System.Collections.Generic;
using System.Text;

namespace OopWithCSharp.OOP
{
    public class ExpressionBodiedMembers:IDisposable
    {
        private string Name;

        public String FristName {

            get => Name.ToUpper();
            set => Name = value;
        }
        public ExpressionBodiedMembers(string fristName, string lastName) => Name = $"{fristName} {lastName}";

        public string UpperCaseName() => Name.ToUpper();

        public override string ToString() => GetType().Namespace;
        public string Assembly => System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        ~ExpressionBodiedMembers() => Console.WriteLine($"The {ToString()} destructor is executing.");

    }
}
