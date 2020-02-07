using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface Loan
    {
        void Interest();
    }
    interface Gloan:Loan
    {
        void Goldinterest();
    }
    public abstract class Bank
    
    {
        protected string bname;
        protected string loc;
        public Bank(string bname,string loc)
        {
            this.bname = bname;
            this.loc = loc;
        }
        public abstract void Display();
    }
    public class SBI : Bank,Gloan 
    {
        string manager;
        public SBI(string bname, string loc,string manager):base(bname, loc)
        {
            this.manager = manager;
        }
        public override void Display()
        {
            Console.WriteLine("name" + this.bname + "loc" + this.loc + "manager" + this.manager);
        }
        public void Interest()
        {
            Console.WriteLine("sbi interest is 12%");
        }
        public void Goldinterest()
        {
            Console.WriteLine("sbi gold interest is 12%");
        }

    }
    public class ICICI : Bank,Loan
    {
        string head;
        public ICICI(string bname, string loc, string head) : base(bname, loc)
        {
            this.head =head;
        }
        public override void Display()
        {
            Console.WriteLine("name" + this.bname + "loc" + this.loc + "manager" + this.head);
        }
        public void Interest()
        {
            Console.WriteLine("icici interest is 12%");
        }

    }
}
