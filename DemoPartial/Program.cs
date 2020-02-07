using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
    class Program
    {
        partial class ClassA
        {
            partial void setdata();
            public void print()
            {
                Console.WriteLine("class A");
                setdata();
            }

        }
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.print();
            Console.ReadKey();
        }
    }
}
