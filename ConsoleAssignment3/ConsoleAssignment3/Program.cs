using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryVehichle;

namespace ConsoleAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("BMW", "Black", 0, 4, 0);
            Vehicle bus = new Vehicle("TATA", "Blue", 2, 4, 2);
           
            car.start();
            car.Display();
            car.stop();
            Console.WriteLine("--------------BUS--------------");                
            bus.start();
            bus.Display();
            bus.stop();

            

            Console.ReadLine();
        }
    }
}
