using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Threads
{
    class Threadclass
    {
        public void counteven()
        {
            lock (this)
            {
                for (int i = 0; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                    if (i == 50) Thread.Sleep(3000);
                }

            }
        }
        public void countodd()
        {
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
