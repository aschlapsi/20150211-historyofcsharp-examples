using System;

namespace DynamicExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //FirstExample();

            dynamic d = 1;
            var e = 3;
            var testSum = d + e;
            Console.WriteLine(testSum);

            dynamic d1 = 7;
            dynamic d2 = "a string";
            dynamic d3 = DateTime.Today;
            dynamic d4 = System.Diagnostics.Process.GetProcesses();
            int i = d1;
            string str = d2;
            DateTime dt = d3;
            System.Diagnostics.Process[] procs = d4;
            Console.WriteLine("{0}, {1}, {2}, {3}", i, str, dt, procs.Length);
        }

        private static void FirstExample()
        {
            ExampleClass exampleClass = new ExampleClass();
            //exampleClass.ExampleMethod1(10, 4);

            dynamic dyn_ec = new ExampleClass();
            dyn_ec.ExampleMethod(10, 4);
            dyn_ec.SomeMethod("Some argument", 7, null);
        }
    }
}
