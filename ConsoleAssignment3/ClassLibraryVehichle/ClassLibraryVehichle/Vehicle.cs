using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehichle
{
    public enum VehType
    {
        Car = 0,
        Truck,
        Bus
    }
    public enum FuelType
    {
        Diesel,
        Petrol,
        CNG
    }
    public class Vehicle
    {
        
            string name;
            string color;
            int NoOfWheels;
            int Vehtype;
            int Fueltype;

            public Vehicle(string _name, string _color)
            {
                name = _name;
                color = _color;
            }

            public Vehicle(params Object[] arr)
            {
               
                name = (string)arr[0];
                color = (string)arr[1];
                Vehtype = (int)arr[2];
                NoOfWheels = (int)arr[3];
                Fueltype = (int)arr[4];



               

            }

            public void start()
            {
                if (Vehtype == (int)VehType.Bus)
                {
                    Console.WriteLine("Bus has started.....");
                }

                else if (Vehtype == (int)VehType.Car)
                {
                    Console.WriteLine("Car has started.....");
                }

                else if (Vehtype == (int)VehType.Truck)
                {
                    Console.WriteLine("Truck has started.....");
                }


            }

            public void stop()
            {
                if (Vehtype == (int)VehType.Bus)
                {
                    Console.WriteLine("Bus has stoped.....");
                }

                else if (Vehtype == (int)VehType.Car)
                {
                    Console.WriteLine("Car has stoped.....");
                }

                else if (Vehtype == (int)VehType.Truck)
                {
                    Console.WriteLine("Truck has stoped.....");
                }


            }

            public void Display()
            {
            string veh;
            string fuel;
            if (Vehtype == 0)
            {
                veh = "Car";
                fuel = "Petrol";
            }

            else if (Vehtype == 1)
            {
                veh = "Truck";
                fuel = "Diesel";
            }
            else
            {
                veh = "Bus";
                fuel = "Diesel";
            }

            Console.WriteLine("Vehicle Type : {0}", veh);
                Console.WriteLine("Vehicle Name : {0}", name);
                Console.WriteLine("Vehicle Color : {0}", color);
                Console.WriteLine("No. Of Wheels : {0}", NoOfWheels);
                Console.WriteLine("Fuel Type : {0}", fuel);
            }

        
    }
}
