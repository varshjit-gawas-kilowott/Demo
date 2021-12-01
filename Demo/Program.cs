using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
       static int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

        public static void Main(string[] args)
        {
            var sobject = new Stats();
            sobject.Numbers = a;

            var sum = sobject.CalSum();
            Console.WriteLine($"Sum:{sum}");

            var mean = sobject.CalMean();
            Console.WriteLine($"Mean:{mean}");

            var median = sobject.CalMedian();
            Console.WriteLine($"Median:{median}");

            var mode = sobject.CalMode();
            Console.WriteLine($"Mode:{mode}");

            Console.ReadLine();
        }
    }
}
