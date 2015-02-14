namespace Counter1
{
    public class EventSource
    {
        private int _counter = 0;

        public event CounterEventHandler CounterChanged;

        public void IncrementCounter()
        {
            _counter++;
            RaiseCounterEvent(new CounterEventArgs(_counter));
        }

        public void ResetCounter()
        {
            _counter = 0;
            RaiseCounterEvent(new CounterEventArgs(_counter));
        }

        protected virtual void RaiseCounterEvent(CounterEventArgs args)
        {
            var counterChanged = CounterChanged;
            if (counterChanged != null)
                counterChanged(this, args);
        }
    }
}
