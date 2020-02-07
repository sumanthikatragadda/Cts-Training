using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    class Program
    {
        public static void Accept()
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("hi" + name );
            Console.WriteLine("Welcome to world of c#");

        }
        public static void Ass3()
        {
         
            Console.WriteLine("enter 2 nos");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for(int i = a + 1; i < b ; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void Ass4()
        {
            Console.WriteLine("enter no");
            int a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public static void FtoC()
        {
            Console.WriteLine("enter farenheit");
            int a = int.Parse(Console.ReadLine());
            int c = (a - 32) * 5 / 9;
            Console.WriteLine(c);

        }

        public static void Series()
        {
            int i = 0;
            for(i=0;i<=25;i++)
            {
                Console.WriteLine(i * i);
            }
        }
        public static void Fact()
        {
            int f = 1;
            Console.WriteLine("enter no");
            int a = int.Parse(Console.ReadLine());
            for(int i = 1;i<=a;i++)
            {
               
                f *= i;
            }
            Console.WriteLine(f);

        }
        public static void Fibnocci()
        {
            int a = 0, b = 1,c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i=0;i<=40;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }

        public static void Multiply()
        {
            Console.WriteLine("enter no");
            int a = int.Parse(Console.ReadLine());
            for(int i=0;i<=10;i++)
            {
                int j = a * i;
                Console.WriteLine(a + "*" + i+"="+j);
            }
        }
        public static void Div7()
        {
            for(int i=200;i<300;i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of c#");
            //Accept();
            //Ass3();
            // Ass4();
            //FtoC();
            //Series();
            //Fact();
            // Fibnocci();
            // Multiply();
            Div7();
            Console.ReadKey();
        }
    }
}
