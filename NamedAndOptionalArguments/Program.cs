using System;

namespace NamedAndOptionalArguments
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CalculateBmi(97, 184));
            Console.WriteLine(CalculateBmi(size: 97, height: 184));
            Console.WriteLine(CalculateBmi(height: 184, size: 97));
            //Console.WriteLine(CalculateBMI(weight: 97, 184)); 
            Console.WriteLine(CalculateBmi(97, height: 184));

            var ec1 = new ExampleClass("ExampleClass #1");
            var ec2 = new ExampleClass();
            ec1.ExampleMethod(42);
            ec2.ExampleMethod(21, optionalInt: 43);
            ec2.ExampleMethod(21, "other string");
        }

        private static int CalculateBmi(int size, int height)
        {
            var heightInMeters = height/100.0;
            return (int) (size / (heightInMeters * heightInMeters));
        }
    }

    public class ExampleClass
    {
        private readonly string _name;

        public ExampleClass(string name = "Default name")
        {
            _name = name;
        }

        public void ExampleMethod(
            int required,
            string optionalString = "default string",
            int optionalInt = 10)
        {
            Console.WriteLine("{0}: {1}, {2}, and {3}.",
                _name, required, optionalString, optionalInt);
        }
    }
}
