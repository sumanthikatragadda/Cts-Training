using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Properties
{
    class Class1
    {
        static void Main()
        {

            string[] names = new string[4]
            {
                "aaa",
                "ddd",
                "ccc",
                "fff"
            };
            int flag = 1;
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            foreach (string i in names)
            {
                if (name == i)
                {
                    flag = 1;
                    Console.WriteLine("present");
                    break;

                }

            }
            if(flag==0)
            {
                Console.WriteLine("not exists");
            }
                
            Console.ReadKey();
        } 

    }
}
