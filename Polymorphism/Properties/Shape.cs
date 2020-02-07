using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Shape
    {
        int len;
        int wid;
        int br;
        public void draw()
        {
            Console.WriteLine("shape is drawn");
        }
        public void draw(int len)
        {
            this.len = len;
        }
        public void draw(int a,int b)
        {
            Console.WriteLine("shape is drawn");
        }
        public void draw(int x,int y,int z)
        {
            Console.WriteLine("shape is drawn");
        }
    }
}
