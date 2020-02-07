using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBy
{
    class Calculator
    {
        int v1, v2;
        public int V1
        {
            get => v1; set => v1 = value;
        }
        public int V2
        {
            get => v2; set => v2 = value;
        }
        public Calculator(int v1,int v2)
        {
            this.v1 = v1;
            this.v2 = v2;

        }
        public Calculator()
        {

        }
        public void Sub(int num1,int num2,out int res)
        {
            res = num1 - num2;
        }
        public void Swap(ref int num1,ref int num2)
        {
            int t = num1;
            num1 = num2;
            num2 = t;
            Console.WriteLine(num1);
            Console.WriteLine(num2);

        }
        public void Add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);
        }

    }
}
