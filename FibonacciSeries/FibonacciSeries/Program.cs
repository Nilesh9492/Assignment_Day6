using System;

namespace FibonacciSeries
{
    class Program
    {
        public static int fib(int N)
        {
            if (N<=1)
            {
                return N;
            }
            else
            {
                return fib(N - 1) + fib(N - 2);
            }
        }
        static void Main(string[] args)
        {
            int N = 4;
            Console.WriteLine(fib(N));
        }
    }
}
