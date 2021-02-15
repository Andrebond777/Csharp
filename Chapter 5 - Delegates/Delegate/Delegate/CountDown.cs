using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegate
{
    class CountDown
    {
        private string message;
        private int milliseconds;
        public CountDown(string Message, int Seconds, Observer.ObserverHandler Observer)
        {
            message = Message;
            milliseconds = Seconds * 1000;
            Count(Observer);
        }

        private void Count(Observer.ObserverHandler Observer)
        {
            Thread.Sleep(milliseconds);
            Observer(message);
        }
    }
}
