using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    sealed class Singleton
    {
        static int count = 0;
        public static Singleton Instance=null;
        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                    return new Singleton();
                else
                    return Instance;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void Details(string s)
        {
            Console.WriteLine(s);
        }
    }
}
