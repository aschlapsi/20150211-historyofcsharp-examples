using System;
using System.Collections.Generic;

namespace Counter2
{
    public class Program
    {
        public static void Main(string[] a)
        {
            List<int> counters = new List<int>();
            EventSource eventSource = new EventSource();

            eventSource.CounterChanged += delegate(object sender, CounterEventArgs args)
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

            counters.ForEach(delegate(int counter)
            {
                if (counter % 2 == 0)
                    Console.WriteLine(counter);
            });
        }
    }
}
