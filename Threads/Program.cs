using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starts");
            Threadclass t = new Threadclass();
            Thread th = new Thread(t.counteven);
            Thread th1 = new Thread(t.countodd);
            //th.Priority = ThreadPriority.Lowest;
            //th1.Priority = ThreadPriority.Highest;
            th.Start();
            th1.Start();
            //th.Suspend();
            Console.WriteLine("suspended");
            //th.Resume();
            Console.WriteLine("ended");
            Console.ReadKey();
        }
    }
}
