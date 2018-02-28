using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void OutputArray(int[] arr)
        {
            Console.WriteLine(new string('-', 70));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("| " + arr[i] + " ");
            }
            Console.WriteLine("|\n" + new string('-', 70));
        }

        static int[] DeleteDuplicates(int[] arr)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    res.Add(arr[i]);
                }
            }
            res.Add(arr[arr.Length - 1]);
            return res.ToArray();
        }

        private static int[] GenerateRandomSortedArray(int num)
        {
            Random rand = new Random();
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr[i] = rand.Next(-10, 10);
            }
            Array.Sort(arr);
            return arr;
        }

        static void Main(string[] args)
        {
            int num = 15;
            int[] arr = GenerateRandomSortedArray(num);
            Console.WriteLine("Initial array:");
            OutputArray(arr);
            Console.WriteLine("Array without duplicates:");
            OutputArray(DeleteDuplicates(arr));
            Console.WriteLine("Initial array isn't changed:");
            OutputArray(arr);
            Console.ReadLine();
        }
    }
}
