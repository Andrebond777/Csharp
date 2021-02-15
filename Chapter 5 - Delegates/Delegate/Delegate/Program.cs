using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer = new Observer();
            Observer.ObserverHandler oh1 = Show_Message;
            var counter = new CountDown("Hello", 0, oh1);
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
    }
}
