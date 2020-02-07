using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPoly
{
    
        class A
        {
            public virtual void display()
            {
                Console.WriteLine("A");
            }
        }
        class B:A
        {
            public override void display()
            {
                Console.WriteLine("B");
            }
        }
        class C:A
        {
            public override void display()
            {
                Console.WriteLine("C");
            }
        }
    
}
