using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    interface Ifactory
    {
         void manufacture(int cnt);
    }
    class Bike:Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("bike manufacturing" + cnt);
        }
    }
    class Car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("car manufacturing" + cnt);
        }
    }
    //actual creation class
    abstract class VehicleFactory
    {
        public abstract Ifactory genetrateVehicles(string type);
    }
    class ConcreteVehicleFactory:VehicleFactory
    {
        public override Ifactory genetrateVehicles(string type)
        {
            
                if(type=="Bike")
                   return new Bike();
                else
                    return new Car();
                    
               
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConcreteVehicleFactory();
            Ifactory myvehicle= obj.genetrateVehicles("Bike");
            myvehicle.manufacture(10);
            myvehicle = obj.genetrateVehicles("car");
            myvehicle.manufacture(30);
            Console.ReadKey();
        }
    }
}
