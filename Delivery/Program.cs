using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery();
            Console.WriteLine("menu" + "\n" + "1.player details" + "\n" + "2.run details");
            int ch=0;
            ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("enter bowler name");
                string bowler = Console.ReadLine();
                Console.WriteLine("enter batsman name");
                string batsman = Console.ReadLine();
                d.display(bowler, batsman);
            }
            else if (ch == 2)
            {
                Console.WriteLine("enter runs");
                int runs = int.Parse(Console.ReadLine());
                d.display(runs);
            }
            else
                Console.WriteLine("invalid");
            Console.ReadKey();
        }
    }
}
