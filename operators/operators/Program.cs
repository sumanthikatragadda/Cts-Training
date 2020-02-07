using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            byte  i = 10;
            byte b1 = (byte)(i * 10);
            long l2 = 12500;
            int i2 = (int)l2;
            byte b2 = (byte)i;
            Console.WriteLine("values:{0} values2{1}"3, i2, b2);
            Console.ReadKey();
            
        }
    }
}
