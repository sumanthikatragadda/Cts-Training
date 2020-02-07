using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            
                al.Add(5);
                al.Add("sumanthi");
                al.Add(100);
                al.Add('s');
            al.Remove('s');
            
            foreach(var x in al)
            {
                Console.WriteLine(x);
            }
            Queue ql = new Queue();
            ql.Enqueue(12);
            ql.Enqueue("gh");
            ql.Dequeue();
            foreach(var e in ql)
            {
                Console.WriteLine(e);
            }
            Stack sl = new Stack();
            sl.Push(12);
            sl.Push("as");
            sl.Push('a');
            
            
            foreach (var q in sl)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine(sl.Peek());
            Hashtable ht = new Hashtable();
            ht.Add('a', 1);
            ht.Add("dot", 60);
            ht.Add("fk",10);
            foreach(var r in ht.Keys)
            {
                Console.WriteLine(r);
                Console.WriteLine(ht[r]);
            }
            List<int> li = new List<int>();
            li.Add(15);
            li.Add('a');
            
            foreach(int l in li)
            {
                Console.WriteLine(l);
            }
            Queue<string> gql = new Queue<string>();
            gql.Enqueue("abc");
            gql.Enqueue("gh");
            gql.Dequeue();
            foreach (var g in gql)
            {
                Console.WriteLine(g);
            }
            Stack<float> gsl = new Stack<float>();
            gsl.Push(12);
            gsl.Push(12.4f);
            gsl.Push(23.1f);


            foreach (var s in gsl)
            {
                Console.WriteLine(s);
            }
            HashSet<int> hs = new HashSet<int>();
            hs.Add(12);
            hs.Add(45);
            hs.Add(12);
            foreach(var h in hs)
            {
                Console.WriteLine(h);
            }
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "asc");
            dt.Add(2, "anv");
            dt.Add(3, "adf");
            foreach(KeyValuePair<int,string> d in dt)
            {
                Console.WriteLine(d.Value);
                Console.WriteLine(d.Key);
            }
            Console.ReadKey();
        }
    }
}
