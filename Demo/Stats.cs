using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Stats
    {
        internal int[] Numbers { private get; set; }

        internal int CalSum()
        {
            int sum = 0;
            foreach (int i in Numbers)
            {
                sum += i;
            }
            // this uses a nifty util from .NET from the LINQ namespace
            // see the "using..." section at the top of the file
            return sum;
        }
        internal double CalMean()
        {
            int n = Numbers.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += Numbers[i];

            return (double)sum / (double)n;
        }

        internal double CalMedian()
        {
            int n = Numbers.Length;
            // Checks if input array has even or odd number of elements and finds the average
            if (n % 2 != 0)
                return (double)Numbers[n / 2];

            // Gets position of the median
            return (double)(Numbers[(n - 1) / 2] + Numbers[n / 2]) / 2.0;
        }

        internal int CalMode()
        {
            int n = Numbers.Length;
            // stores max value of input array
            int max = Numbers.Max();


            int t = max + 1;
            int[] count = new int[t];
            for (int i = 0; i < t; i++)
                count[i] = 0;

            // Stores count of each element of input array
            for (int i = 0; i < n; i++)
                count[Numbers[i]]++;

            // mode is the index with maximum count
            int mode = 0;
            int k = count[0];
            for (int i = 1; i < t; i++)
            {
                if (count[i] > k)
                {
                    k = count[i];
                    mode = i;
                }
            }

            return mode;

        }
    }
}
