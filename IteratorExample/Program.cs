using System;
using System.Collections.Generic;

namespace IteratorExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            foreach (int number in program.GetNumbers(0, 10, 10))
                Console.WriteLine("From Main: {0}", number);
        }

        private IEnumerable<int> GetNumbers(int start, int end, int factor)
        {
            Console.WriteLine("Start GetNumbers()");

            for (int i = start; i <= end; i++)
            {
                yield return i*factor;
                Console.WriteLine("From GetNumbers: Generating next number");
            }

            Console.WriteLine("End GetNumbers()");
        }
    }
}
