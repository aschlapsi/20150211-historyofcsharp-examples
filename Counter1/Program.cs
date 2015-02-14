using System;
using System.Collections;

namespace Counter1
{
    public class Program
    {
        private readonly ArrayList _counters = new ArrayList();

        public static void Main(string[] args)
        {
            EventSource eventSource = new EventSource();
            Program program = new Program();

            eventSource.CounterChanged += new CounterEventHandler(program.EventHandler);

            eventSource.IncrementCounter();
            eventSource.IncrementCounter();
            eventSource.IncrementCounter();
            eventSource.IncrementCounter();
            eventSource.ResetCounter();
            eventSource.IncrementCounter();
            eventSource.IncrementCounter();

            eventSource.CounterChanged -= new CounterEventHandler(program.EventHandler);

            program.ShowCounters();
        }

        private void EventHandler(object sender, CounterEventArgs args)
        {
            Console.WriteLine(
                "Counter event from object of type {0}",
                sender.GetType());

            _counters.Add(args.Counter);
        }

        private void ShowCounters()
        {
            foreach (int counter in _counters)
            {
                if (counter % 2 == 0)
                    Console.WriteLine(counter);
            }
        }
    }
}
