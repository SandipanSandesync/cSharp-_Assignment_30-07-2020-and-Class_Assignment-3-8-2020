using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignmentAbsClassInterface
{
    interface IVolume
    {
        double Volume { get; }
    }
    interface IArea
    {
        double SurfaceArea();

    }
    interface ISolid 
    {
         double  Volume { get; }
          double SurfaceArea();
    }

    abstract class Solid : ISolid
    {
        public double radius;
       public  const double pi = 3.142;
       
        


        public abstract double Volume { get; }
        public abstract double SurfaceArea();
        public double Radius 
        {
            get { return radius; }
            set { radius = value; }
        }

        public Solid(double radi)
        {
            radius = radi;

        }
    }

    class Cylinder : Solid
    {
        public double Height;
        
        
        public Cylinder(double _height,double radius):base(radius)
        {
            Height = _height;

        }
        public override double Volume
        {
            get { return pi * Radius * Radius * Height; }
        }


        public override double SurfaceArea()
        {
            var surfaceA = 2 * pi * Radius * (Radius + Height);
            return surfaceA;
           
        }
    }
    class Sphere : Solid
    {
        public double Height;


        public Sphere(double _height, double radius) : base(radius)
        {
            Height = _height;

        }
        public override double Volume
        {
            get { return 4 * pi * Radius * Radius; }
        }


        public override double SurfaceArea()
        {
            var surfaceA = (4 / 3) * pi * Radius * Radius * Radius;
            return surfaceA;

        }
    }

    class Program
        {
        static void ShowMethod()
        {
            Cylinder c = new Cylinder(5.6, 1.6);
            Console.WriteLine("Surface area :{0}", c.SurfaceArea());
            Console.WriteLine("Volume is :{0}", _ = c.Volume);

            Console.WriteLine("----------sphere---------");
            Sphere s = new Sphere(5.6, 1.6);
            Console.WriteLine("Surface area :{0}", s.SurfaceArea());
            Console.WriteLine("Volume is :{0}", _ = s.Volume);
        }
      
            static void Main(string[] args)
            {
            Program.ShowMethod();
          

            Console.Read();
             }

        }
}

