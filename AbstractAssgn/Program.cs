using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssgn
{
    class Program
    {
        static void Main(string[] args)
        {
            Undergraduate u = new Undergraduate();
            Graduate g = new Graduate();
            float grade = float.Parse(Console.ReadLine());
            u.Ispassed(grade);
            g.Ispassed(grade);
            Console.ReadKey();
        }
    }
}
