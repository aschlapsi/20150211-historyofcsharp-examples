using System;

namespace Counter2
{
    public class CounterEventArgs : EventArgs
    {
        private int _counter;

        public CounterEventArgs(int counter)
        {
            Counter = counter;
        }

        public int Counter
        {
            get { return _counter; }
            private set { _counter = value; }
        }
    }
}
