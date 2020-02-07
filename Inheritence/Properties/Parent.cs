using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Parent
    {
        protected int a;
        protected string b;
        public int A
        {
            get => a;
            set => a = value;
        }
        public string B
        {
            get => b;
            set => b = value;
        }
        public void Data(int x, string y)
        {
            this.A = x;
            this.B = y;
        }
        public void Display()
        {
            Console.WriteLine(this.A + " " + this.B);
        }

    }
            class Child:Parent
             {
               protected int c;
                public void Calculate(int num)
               {
                 c = this.a + num;
                 Console.WriteLine(c);
                }
             }
         class Gchild:Child
         {
             int d;
             public void Multiply(int n)
             {
            this.d = n;
            Console.WriteLine(this.d * this.c * this.a);
             }

         }
    
}
namespace DemoProtected
{
    class Exchild:Inheritence.Parent
    {
        public void Exdisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}