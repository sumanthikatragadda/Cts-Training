using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate double calAreapointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //calAreapointer cptr = new calAreapointer(calarea);
            calAreapointer cptr = new calAreapointer(delegate (double r)
            {
                return 3.14 * r * r;
            });
            //double area = cptr(12);
            //Console.WriteLine(area);
            calAreapointer cptr1 = (r => 3.14 * r * r);
            double area = cptr1(10);
            Console.WriteLine(area);

            Func<double, double> f = (r => 3.14 * r * r);
            double area2 = f(14);
            Console.WriteLine(area2);

            Action<string> act = (x => Console.WriteLine(x));
            act("welcome");
            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("cts"));

            int[] a = new int[] { 1, 2, 3, 4 };
            List<string> names = new List<string>();
            names.Add("a");
            names.Add("b");
            names.Add("c");
            int b = a.Count(x => x > 2);
            Console.WriteLine(b);

            List<string> s = names.FindAll(y => y.Contains("a"));
            foreach(string n in s)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
        //public static double calarea(double r)
        //{
        //    return 3.14 * r * r;
        //}
    }
}
