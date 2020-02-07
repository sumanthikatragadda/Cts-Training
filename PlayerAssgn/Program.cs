using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAssgn
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            CricketPlayer c = new CricketPlayer("a","cricket",1,1000,2);
            HockeyPlayer h = new HockeyPlayer("b","hockey",4,"first",10);
            Console.WriteLine("menu" + "\n" + "1.cricketplayer" + "\n" + "2.hockeyplayer");
            Console.WriteLine("enter choice");
            choice = int.Parse(Console.ReadLine());
            if(choice==1)
            {
                c.Displayplayerstatistic();
            }
            else if(choice==2)
            {
                h.Displayplayerstatistic();
            }
            else
            {
                Console.WriteLine("invalid");


            }
            Console.ReadKey();
        }
    }
}
