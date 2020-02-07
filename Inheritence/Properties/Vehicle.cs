using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    abstract class Vehicle
    {

        protected string color;
        public Vehicle()
        {
            this.color = "white";
            Console.WriteLine("constructor from vehicle");
        }
        public abstract void fill();
        public Vehicle(string clr)
        {
            this.color = clr;
            Console.WriteLine("parameter");
        }
        public virtual void start()
        {
            Console.WriteLine("started");
        }
        public void stop()
        {
            Console.WriteLine("stopped");
        }
        
    }
    class Car:Vehicle
    {
        int seat;
        int speed;
        public Car()
        {
            this.seat = 1;
            this.speed = 120;
            Console.WriteLine("constructor from car");
        }
        public Car(string clr,int spd):base(clr)
        {
            
        }
        public override void fill()
        {
            Console.WriteLine("filled");
        }
        public void Run()
        {
            Console.WriteLine(this.color+" car is running"+this.seat);
        }

    }
    class Bus:Vehicle
    {
        int seat;
        int speed;
        public Bus():base("red")
        {
            this.seat = 1;
            this.speed = 120;
            Console.WriteLine("constructor from bus");
        }
        public override void start()
        {
            Console.WriteLine("virtual");
        }
        public override void fill()
        {
            Console.WriteLine("filled");
        }
        public void Drive()
        {
            Console.WriteLine(this.color+"bus is running with speed"+this.speed+""+this.seat);
        }
    }
}
