using System;
using System.Threading.Tasks;

namespace Delegate
{
    class CountDown
    {
        private string _message;
        private int _milliseconds;
        public CountDown(string message, int seconds)
        {
            _message = message;
            _milliseconds = seconds * 1000;
        }
        public void Count(Action<string> Observer)
        {
            Task.Delay(_milliseconds).Wait();
            Observer(_message);
        }
    }
}
