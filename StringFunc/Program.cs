using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            Console.WriteLine(s.Length + " " + s.Replace("e", "s") + s.ToLower());
            Console.WriteLine(s.Contains("lo"));
            Console.WriteLine(String.Compare("fest", "Fest"));
            string s2 = "HELLO";
            Console.WriteLine(s.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(s.ToUpper());
            int n = string.Compare("welCome",3, "come", 0, 4, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine("compare" + n);
            
            int b = 4;
            float a = b;
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
