using System;

namespace Counter1
{
    public delegate void CounterEventHandler(object sender, CounterEventArgs args);

    public class CounterEventArgs : EventArgs
    {
        private readonly int _counter;

        public CounterEventArgs(int counter)
        {
            _counter = counter;
        }

        public int Counter
        {
            get { return _counter; }
        }
    }
}
