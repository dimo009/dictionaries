using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest_3_numbers
{
    class Largest3Nums
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse);
            var sorted = nums.OrderByDescending(x => x).Take(3);
            var biggestThree = sorted.Take(3);
            Console.WriteLine(String.Join(" ", biggestThree));
        }
    }
}
