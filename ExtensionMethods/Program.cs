using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            const string str = "Hello Extension Methods";
            Console.WriteLine(str.WordCount());

            var v = new {Amount = 108, Message = "Hello"};
            Console.WriteLine(v.Amount + v.Message);
        }
    }
}
