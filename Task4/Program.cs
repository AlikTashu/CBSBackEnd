using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static long FibonacciIterative(int num)
        {
            long prev = 0, curr = 1;
            for (int i = 0; i < num - 1; i++)
            {
                checked
                {
                    curr = prev + curr;
                    prev = curr - prev;
                }
            }
            return curr;
        }

        static long FibonacciRecursive(long a)
        {
            return a > 2 ? FibonacciRecursive(a - 1) + FibonacciRecursive(a - 2) : 1;
        }

        static void Main(string[] args)
        {
            int num = 10;
            long[] iterative = new long[num];
            long[] recursive = new long[num];

            for (int i = 0; i < num; i++)
            {
                iterative[i] = FibonacciIterative(i + 1);
                recursive[i] = FibonacciRecursive(i + 1);
                Console.WriteLine($"{i + 1,6:#th} Fibonacci number Iterative: {iterative[i],4}  Recursive: {recursive[i],4}");
            }
            Console.ReadLine();
        }
    }
}
