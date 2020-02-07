using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int n = 0;
               
                Console.WriteLine("enter size");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            if (n % 2 != 0)
            {
                Console.WriteLine("enter elements");
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                int first, mid, last;
                first = a[0];
                mid = a[n / 2];
                last = a[n - 1];
                if (first > mid && first > last)
                {
                    Console.WriteLine(first + "is highest");
                }
                else if (mid > last)
                {
                    Console.WriteLine(mid + "is high");

                }
                else
                    Console.WriteLine(last + "is high");
            }
            else
            {
                Console.WriteLine("odd");

            }
                Console.ReadKey();
            
        }
    }
}
