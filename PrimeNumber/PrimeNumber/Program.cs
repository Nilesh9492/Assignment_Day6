using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check whether Prime Number or not:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i != 0)
                {
                    a++;
                }
                

            }
            if (n-a==2)
            {
                Console.WriteLine("Given number is Prime Number");
            }
            else
            {
                Console.WriteLine("Given number is not Prime Number");
            }
        }
    }
}
