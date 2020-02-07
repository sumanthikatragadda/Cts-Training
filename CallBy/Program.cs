using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            c.Add(x, y);
            c.Swap(ref x, ref y);
            c.Sub(x, y, out int res);
            Console.WriteLine(res);
            Console.WriteLine(x + "" + y);
            Console.ReadKey();
        }
    }
}
