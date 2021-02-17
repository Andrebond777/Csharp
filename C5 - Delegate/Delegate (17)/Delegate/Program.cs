using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<String> Observer = message => Console.WriteLine(message);
            var counter = new CountDown("Hello", 0);
            counter.Count(Observer);
        }
    }
}
