using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        public static void switchcase(int c,int no)
        {
            switch(c)
            {
                case '1':
                        if(no%2==0)
                        {
                            Console.WriteLine( "even");
                        }
                        else
                        {
                            Console.WriteLine( "odd");
                        }
                    break;
                case '2':
                    
                            int i = 1;
                            for (; i <= no; i++)
                            {
                                Console.Write(i + "\t");
                            }
                            break;
                case '3':
                   
                            
                    for (i = 0; i <= 10; i++)
                    {
                        int j;
                        j = no * i;
                        Console.WriteLine(no+ "*"+i+ "=" +j);

                    }
                    break;
            }      
                
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("enter no");
            int  no = int.Parse(Console.ReadLine());
            Console.WriteLine("1.even/odd \n 2.natural nos \n 3.multiplication table \n 4.exit");
            Console.WriteLine("enter choice:");
            int c = int.Parse(Console.ReadLine());
            switchcase(no,c);
            Console.ReadKey();
        }
    }
}
