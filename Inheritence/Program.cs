using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            Gchild g = new Gchild();
            p.Data(23, "ss");
            p.Display();
            c.Data(26, "sf");
            c.Display();
            c.Calculate(30);
            g.Data(33, "sd");
            g.Display();
            g.Calculate(45);
            g.Multiply(2);
            //Vehicle v = new Vehicle();
            Car alto = new Car("blue",20);
            Bus volvo = new Bus();
            //v.start();
            //v.stop();
            alto.start();
            alto.Run();
            alto.fill();
            alto.stop();
            volvo.start();
            volvo.Drive();
            volvo.fill();
            volvo.stop();
            Console.ReadKey();

        }
    }
}
