using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.draw();
            s.draw(10);
            s.draw(12, 34);
            s.draw(3, 5, 6);
            Console.ReadKey();
        }
    }
}
