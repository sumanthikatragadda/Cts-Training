using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsBooking
{
    class Passenger:Exception
    {
        int age;
        string name;
        public Passenger(string msg):base(msg)
        {

        }
        public void Booking(int ntickets)
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
           
        }
        
    }
   
    
}
