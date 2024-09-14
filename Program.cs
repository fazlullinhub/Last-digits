using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, 12, 34, 56, -2, 45, 78, 90, 22, 34, 12, 56, -7 };

            var lastDigits = numbers.Where(x => x > 0).Select(x => x % 10).ToList();

            var DistinctLastDigits = new List<int>();
            foreach (var number in lastDigits)
            {
                if (!DistinctLastDigits.Contains(number))
                {
                    DistinctLastDigits.Add(number);
                }
            }

            Console.WriteLine("Last digits of positive numbers:");
            foreach (var number in DistinctLastDigits)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
