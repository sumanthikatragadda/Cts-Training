using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssgn
{
    
    abstract class Student
    {
        protected string name;
        protected int id;
        protected float grade;
        public abstract Boolean Ispassed(float grade);

    }
    class Undergraduate:Student
    {
        public override Boolean Ispassed(float grade)
        {
            if (grade >= 70.0)
            {
                Console.WriteLine("passed");
                return true;
            }
            else
            {
                Console.WriteLine("fail");
                return false;
            }
        }

    }
    class Graduate : Student
    {
        public override Boolean Ispassed(float grade)
        {
            if (grade >= 80.0)
            {
                Console.WriteLine("passed");
                return true;
            }
            else
            {
                Console.WriteLine("passed");
                return false;
            }
        }

    }

}
