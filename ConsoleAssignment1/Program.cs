using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment1
{
     abstract class Quadrilateral
    {
        public int length;
        

        

        public abstract int Area();
        
    }
    class Square : Quadrilateral
    {
        public Square()
        {

        }
        public Square(int _length)
        {
            length = _length;
           

        }
        public override int Area()
        {
            int area_square;
            area_square = 4 * length;
            //Console.WriteLine("Area of the square is :{0}",area_square);
            return area_square;

        }

    }
    class Rectangle : Quadrilateral
    {
        public int breadth;
        public Rectangle()
        {

        }
        public Rectangle(int _length, int _breadth) 
        {
            breadth = _breadth;
            length = _length;
        }

        public override int Area()
        {
            int area_rec;
            area_rec =length*breadth;
            // Console.WriteLine("Area of the Rectangle is :{0}", area_rec);
            return area_rec;
        }
        public bool IsSquare { get; set; }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(4);
            Console.WriteLine("Square area :" +s.Area());
            Rectangle r = new Rectangle(5, 5);
            Console.WriteLine(  "Rectangle area :" +r.Area());
            int x = s.Area();
            int y = r.Area();
            if (x > y)
            {
                Console.WriteLine("Square area is greater than rectangle area");
            }
            else
            {
                Console.WriteLine("Rectangle area is greater than square area");
            }
           
            
           
          
            
            Console.Read();
        }
    }
}
