using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program1
    {
        static void Main(string[] args)
        {
            SBI s = new SBI("sbi", "hyd", "abc");
            ICICI c = new ICICI("icici", "hyd", "abc");
            s.Display();
            s.Interest();
            s.Goldinterest();
            c.Display();
            c.Interest();
            Console.ReadKey();
        }
    }
}
