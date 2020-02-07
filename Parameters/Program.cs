using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParams
{
    class calculator
    {
        public void Add(params int[] x)
        {
            int r = 0;
            foreach (int i in x)
                r += 1;
            Console.WriteLine(r);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            c.Add(12, 23, 10, 20, 40);
            Console.WriteLine("hello");
            Console.ReadKey();
        }
    }
}
