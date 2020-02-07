using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 2, 5, 7, 4 };
            //int sum = 0;
            foreach(int i in a)
            {
                //sum = sum + i;
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

           // Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
