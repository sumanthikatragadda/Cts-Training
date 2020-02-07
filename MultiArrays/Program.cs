using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 3];
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int top = marks[0,0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (marks[i, j] > top)
                        top = marks[i, j];
                }

                Console.WriteLine("highest is" + (i + 1) + "is" + top);
            }
            Console.ReadKey();
        }
    }
}
