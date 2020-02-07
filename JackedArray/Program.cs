using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] names = new string[3][];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter size");
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size]; 

            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<names[i].Length;j++)
                {
                    names[i][j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.WriteLine(" "+names[i][j]
                        );
                }
            }
            foreach(string s in names[2 j])
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
