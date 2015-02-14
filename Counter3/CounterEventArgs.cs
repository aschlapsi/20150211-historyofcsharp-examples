using System;

namespace Counter3
{
    public class CounterEventArgs : EventArgs
    {
        public CounterEventArgs(int counter)
        {
            Counter = counter;
        }

        public int Counter { get; private set; }
    }
}
