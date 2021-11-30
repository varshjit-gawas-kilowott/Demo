using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int n = a.Length;
            Console.Write("Mean = " + Class1.FindMean(a, n) + "\n");
            Console.Write("Median = " + Class1.FindMedian(a, n) + "\n");
            Console.Write("Median = " + Class1.Findmode(a, n) + "\n");
        }
    }
}
