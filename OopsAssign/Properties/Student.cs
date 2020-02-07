using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAssign
{
    class Student
    {
        private int rollno;
        public string name { get; set; }
        int sem;
        string branch;
        int marks;
        public int Rollno
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }
        }
        public int Sem
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;
            }
        }
        
        public int Marks
        {
            get
            {
                return marks;
            }
        }
        public Student(string name,int rollno,string branch,int marks)
        {
            this.name = name;
            this.Rollno = rollno;
            this.branch = branch;
            this.Sem = sem;
        }
        public Student()
        {
            name = "ss";
            rollno = 45;
            branch = "cse";
            sem = 1;

        }
        public void AcceptDetails()
        {
            Console.WriteLine("enter marks");
            this.marks = int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch");
            branch = Console.ReadLine();

            Console.WriteLine("student details are accepted");

        }
        public void Display()
        {
            Console.WriteLine(name + "\n" + marks);
            
            Console.WriteLine("details are displayed");
        }

    }
}
