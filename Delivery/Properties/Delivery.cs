using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    class Delivery
    {
        string bowler;
        string batsman;
        int runs;
        
        public void display(string bowler,string batsman)
        {
            Console.WriteLine(bowler + "\n" + batsman);
        }
        public void display(int runs)
        {
            if (runs == 6)
                Console.WriteLine("six");
            else if (runs == 4)
                Console.WriteLine("four");
            else
                Console.WriteLine(runs);
        }
    }
}
