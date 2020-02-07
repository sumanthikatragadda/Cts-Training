using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Stringhelper
    {
        public string Firstcasechange(this string name)
        {
            char[] input = name.ToCharArray();
            input[0] = Char.IsUpper(input[0]) ? Char.IsLower(input[0]) : Char.ToUpper(input[0]);
                return new string(input);

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string name = "welcome";
            Console.WriteLine(name.Firstcasechange());

        }
    }
}
