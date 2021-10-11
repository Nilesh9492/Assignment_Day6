using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check whether perfect number or not:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=1; i<n; i++)
            {
                if (n%i==0)
                {
                    sum = sum + i;
                }
                
            }
            if(sum==n)
            {
                Console.WriteLine("Given number is Perfect Number");
                
            }
            else
            {
                Console.WriteLine("Given number is not Perfect Number");
            }
        }
    }
}
