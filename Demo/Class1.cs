using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Class1
    {
        public static double FindMean(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];
            return (double)sum / (double)n;
        }
        public static double FindMedian(int[] a, int n)
        {
            Array.Sort(a);
            if (n % 2 != 0)
                return (double)a[n / 2];
            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;
        }
        public static double Findmode(int[] a, int n)
        {
            int maxValue = 0, maxCount = 0;
            for (int i = 0; i < n; ++i)
            {
                int count = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (a[j] == a[i])
                        ++count;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = a[i];
                }
            }
            return maxValue;
        }
    }
}
