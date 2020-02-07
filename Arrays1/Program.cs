using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {

            int high, low;
            Console.WriteLine("enter size");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            high = a[0];
            low = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > high)
                    high = a[i];
                if (a[i] < low)
                    low = a[i];
            }
            Console.WriteLine(high + "\n" + low);
            Console.ReadKey();
        }
    }
}
