using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        int ano;
        static string bname = "SBI";
        string name;
        int amount;
        int balnc;
        
        public Account()
        {
       
        }
        public Account(int ano,string name,int balnc )
        {
            this.ano = ano;
            this.name = name;
            
            this.balnc = balnc;
        }
        public int Deposit()
        {
            Console.WriteLine("enter amount");
            amount = int.Parse(Console.ReadLine());
            this.balnc=this.balnc + amount;
            return balnc;
        }
        public int Withdrawl()
        {
            Console.WriteLine("enter amount");
            amount = int.Parse(Console.ReadLine());
            this.balnc = this.balnc - amount;
            return balnc;
        }

        public void Display()
        {
            Console.WriteLine("BANK name"+bname+"\n"+"account no"+this.ano+"\n"+"name"+this.name+"\n"+"balane"+this.balnc);
        }


    }
}
