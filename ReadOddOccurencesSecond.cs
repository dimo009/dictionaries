using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Test
{
    class ReadOddOccurencesSecond
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var words = text.Split(' ');
            Console.WriteLine(String.Join(", ",
            words.Where(x => words.Where(y => y == x).Count() % 2 == 1).Distinct()));
        }
    }
}
