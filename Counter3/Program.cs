using System;
using System.Collections.Generic;
using System.Linq;

namespace Counter3
{
    public class Program
    {
        public static void Main(string[] a)
        {
            var counters = new List<int>();
            var eventSource = new EventSource();

            eventSource.CounterChanged += (sender, args) =>
                {
                    Console.WriteLine(
                        "Counter event from object of type {0}",
                        sender.GetType());

                    counters.Add(args.Counter);
                };

            eventSource.IncrementCounter();
            eventSource.IncrementCounter();
            eventSource.IncrementCounter();
            eventSource.IncrementCounter();
            eventSource.ResetCounter();
            eventSource.IncrementCounter();
            eventSource.IncrementCounter();

            foreach (var c in
                from counter in counters
                where counter % 2 == 0
                select counter)
                Console.WriteLine(c);

            //foreach (var counter in counters.Where(counter => counter % 2 == 0))
            //    Console.WriteLine(counter);
        }
    }
}
