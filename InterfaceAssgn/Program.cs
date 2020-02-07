using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssgn
{
    interface Istudent
    {

        int Id { get; set; }
        string Name { get; set; }
        void Details();
    }
    class Resident : Istudent
    {
        int id;
        string name;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Resident(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public  void Details()
        {
            Console.WriteLine("resident"+this.id + " " + this.name);
        }
    }
    class Dayscholar : Istudent
    {
        int id;
        string name;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Dayscholar(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public  void Details()
        {
            Console.WriteLine("dayscholar"+this.id + " " + this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menu" + "\n" + "1.resident" + "\n" + "2.dayscholar");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Resident r = new Resident(id, name);
                r.Details();
            }
            else if (n == 2)
            {
                Dayscholar d = new Dayscholar(id, name);
                d.Details();

            }
            else
                Console.WriteLine("invalid");
            
            Console.ReadKey();

        }
    }
}
