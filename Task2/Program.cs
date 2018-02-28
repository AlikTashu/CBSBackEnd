using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "The “C# Professional” course includes the topics I discuss in my CLR via C# book and teaches how the CLR works thereby showing you how to develop applications and reusable components for the.NET Framework.";

            Console.WriteLine("Input: ");
            Console.WriteLine(input);
            var words = input.Split(' ', '.', ',', '”', '“');
            var res = words.Select(s => s).Distinct().OrderBy(w => w.Length).GroupBy(w => w.Length).Where(g => g.Key > 0);
            foreach (var group in res)
            {
                Console.WriteLine($"Words of length {group.Key}, Count: {group.Count()}");
                foreach (var word in group)
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadLine();
        }
    }
}
