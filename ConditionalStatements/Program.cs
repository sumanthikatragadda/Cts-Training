using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        public static string Evenodd(int i)
        {

            if (i % 2 == 0)
            {
                return "even";

            }
            else
            {
                return "odd";

            }


        }
        public static int Max(int i, int j, int k)
        {
            if ( i > j )
            {
                if ( i > k)
                {
                    return i;
                }
                else
                {
                    return k;
                }

            }
            if ( j > k )
            {
                return j;
            }
        }

        static void Main(String[] args)
        {
            Console.WriteLine("enter a no");
            int i = int.Parse(Console.ReadLine());
            string result = Evenodd(i);
            Console.WriteLine(result);
            Console.WriteLine(Max(3, 5, 7));
            Console.ReadKey();
        }
    }
}
