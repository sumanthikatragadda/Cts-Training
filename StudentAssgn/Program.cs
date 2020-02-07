using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssgn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no");
            int rno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name =Console.ReadLine();
            Console.WriteLine("enter cls");
            string cls = Console.ReadLine();
            Console.WriteLine("enter sem");
            int sem = int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
            string branch = Console.ReadLine();
            Student s = new Student(rno,name,cls,sem,branch);
            s.DisplayResult();
            Console.ReadKey();

        }
    }
}
