using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeStatements
{
    class Program
    {
        public static void Greet(string name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("hello" + name);
                flag++;  
            }
            
        }
        public static void NaturalNos(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag + " ");
                flag++;
            }
        }
        public static int Fact(int k)
        {
            int fact = 1;
            for(int i=1;i<=k;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static string Vowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'a':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                case 'i':
                    result = "vowel";
                    break;
                case 'o':
                    result = "vowel";
                    break;
                case 'u':
                    result = "vowel";
                    break;
                default:
                    result = "consonant";
                    break;


            }
        }

        static void Main(string[] args)
        {
            Greet("guys");
            NaturalNos(100); 
            Console.WriteLine(Fact(4));
            Vowel("h");
            Console.ReadKey();
            Console.WriteLine("enter no");
            Console.WriteLine("1.")


        }
    }
}
