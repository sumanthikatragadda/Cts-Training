using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            Dictionary<string,float> dt = new Dictionary<string, float>();
            Console.WriteLine("enter count");
            c = int.Parse(Console.ReadLine());
            string name;
            int sal;
            for (int i = 0; i < c; i++)
            {


                Console.WriteLine("enter name and salary ");
                name = Console.ReadLine();
                sal = int.Parse(Console.ReadLine());
                dt.Add(name, sal);
            }
            float high = 0;
            string hname=" ";
            foreach (KeyValuePair<string, float> d in dt)
            {
                if (d.Value > high)
                {
                    high = d.Value;
                    hname = d.Key;

                }
            }
                Console.WriteLine("highest is"+ " "+hname);
            
            Console.ReadKey();
        }
    }
}
