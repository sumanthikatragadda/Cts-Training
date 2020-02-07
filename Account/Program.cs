using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            string trans;
            Account a = new Account(12345,"abc",124);
            Console.WriteLine("enter trans type");
            trans = Console.ReadLine();
            if(trans=="deposit")
            {
               a.Deposit();
                a.Display();
            }
            else
            {
                a.Withdrawl();
                a.Display();

            }
            Console.ReadKey();
        }
    }
}
