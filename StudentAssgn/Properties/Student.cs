using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssgn
{
    class Student
    {
        static string clgname="crr";
        int rno;
        string name;
        string cls;
        int sem;
        string branch;
        int[] marks = new int[5];
        public Student(int rno, string name, string cls, int sem, string branch)
        {
            this.rno = rno;
            this.name = name;
            this.cls = cls;
            this.sem = sem;
            this.branch = branch;
        }
        public void DisplayResult()
        {
            int flag=0;
            int sum = 0;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("enter marks for sub"+(i+1));
                marks[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<5;i++)
            {
                
                sum += marks[i];

            }
            float avg = sum / 5;
            Console.WriteLine(avg);
            for(int i=0;i<5;i++)
            {
                if (marks[i] < 35 || avg < 35)
                    flag = 0;
                else
                    flag = 1;
            }
            if (flag == 0)
                Console.WriteLine("fail");
            else
                Console.WriteLine("pass");
        }
        



           



    }
}
