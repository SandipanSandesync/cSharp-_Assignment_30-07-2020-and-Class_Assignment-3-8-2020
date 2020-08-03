using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------part-1----------------------");
            string[] myArray = { "Zebra", "Ant", "Owl", "Lion" };
            Console.WriteLine("------------FOR loop------------");
            for(var i=0;i<myArray.Length;i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("------------ForEach loop---------");
            foreach(var i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------Do-While loop------------");
            var t = 0;
            do
            {
                Console.WriteLine(myArray[t]);
                // _ = myArray[t++];
                t++;



            } while (t < myArray.Length);
            Console.WriteLine("------------While loop---------");

            var k=0;
            while(k<myArray.Length)
            {
                Console.WriteLine(myArray[k]);
                k++;
            }

            Console.WriteLine("----Sorted Array -----------");
            Array.Sort(myArray);
            foreach (var p in myArray)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("----------------------------part2------------------");
            string[] animals = {  "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India"  };

            Console.WriteLine("---Sorted array-----");
            Array.Sort(animals);
            foreach(var a in animals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");
            Array.Sort(places);
            foreach(var pl in places)
            {
                Console.WriteLine(pl);
            }

            Console.Read();
        }
    }
}
