using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Bike
    {
        string name;
        string color;
        //public void SetDetails(string name,string color)
        
        public void StartEngine()
        {
            Console.WriteLine("bike started" + DateTime.Now.Hour);
        }
        public void FillGas(int lt)
        {
            Console.WriteLine("bike filled with" + lt +"litres");
        }
        public int Travel(int d,int s)
        {
            int time = (int)(d / s);
            Console.WriteLine("will reach your destination in" );
            return (time);
        }
    }
}
