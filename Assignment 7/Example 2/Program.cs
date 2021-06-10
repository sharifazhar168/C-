 using System;

namespace Calculator
{
    public class calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int result = calculator.Add(2, 5);
            Console.WriteLine(result);

        }
    }
}