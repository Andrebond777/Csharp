using System;

namespace TryCatch
{
    class OddException : Exception
    {
        public double value { get; }
        public OddException(string message, double val) : base(message)
        {
            value = val;
        }
    }
    public static class Program
    {
        public static double Multiply()
        {
            //Console.Write("Input first number: ");
            double left = 2/*Convert.ToDouble(Console.ReadLine())*/;
            //Console.Write("Input second number: ");
            double right = 1/*Convert.ToDouble(Console.ReadLine())*/;
            var result = left * right;

            if ((int)result % 2 == 0)
                return result;
            else
                throw new OddException("Result is odd", result);
        }
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine(Multiply());
            }
            catch (OddException ex)
            {
                Console.WriteLine(ex.Message + " = " + ex.value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("программа успешно завершила операцию умножения");
        }
    }
}
