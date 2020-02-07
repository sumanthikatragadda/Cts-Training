using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Student mark = new Student();
            mark.Rollno = 23;
            mark.Sem = 1;
            mark.name = "abc";
            mark.AcceptDetails();
            mark.Display();

            Console.ReadKey();
        }
        
    }
}
