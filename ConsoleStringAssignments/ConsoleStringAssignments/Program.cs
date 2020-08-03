using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringAssignments
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1.Concatenate String");
                Console.WriteLine("2.Length of two string");
                Console.WriteLine("3.Substring");
                Console.WriteLine("4.Replace");
                Console.WriteLine("5.UpperCase");
                Console.WriteLine("6.Lowercase");
                Console.WriteLine("7.Trim");
                Console.WriteLine("8.Split");
                Console.WriteLine("9.Exit ");
                Console.WriteLine("Choose One point :");
                choice = Convert.ToInt32(Console.ReadLine());

                string s1;
                string s2;
               


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string :");
                        s2 = Console.ReadLine();
                        Console.WriteLine("After concatenation :{0}", string.Concat(s1, s2));
                        break;
                    case 2:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string :");
                        s2 = Console.ReadLine();
                        Console.WriteLine("Length of 1st string is :{0}", s1.Length);
                        Console.WriteLine("Length of 2nd string is :{0}", s2.Length);
                        break;
                    case 3:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string :");
                        s2 = Console.ReadLine();
                        Console.WriteLine("Substring of s1 :{0}", s1.Substring(3));
                        Console.WriteLine("Substring of s2 :{0}", s2.Substring(2));
                        break;
                    case 4:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string :");
                        s2 = Console.ReadLine();
                        Console.WriteLine("Old string s1 is :{0}", s1);
                        Console.WriteLine("New string after replace :{0}", s1.Replace('a', ' '));

                        Console.WriteLine("Old string s2  is :{0}", s2);
                        Console.WriteLine("New string after replace :{0}", s2.Replace('h', 'a'));
                        break;
                    case 5:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string :");
                        s2 = Console.ReadLine();
                        Console.WriteLine("Uppercase of string s1 is :{0}", s1.ToUpper());
                        Console.WriteLine("Uppercase of string s2 is :{0}", s2.ToUpper());
                        break;
                    case 6:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Enter 2nd string :");
                        s2 = Console.ReadLine();
                        Console.WriteLine("Lowercase of string s1 is :{0}", s1.ToLower());
                        Console.WriteLine("Lowercase of string s2 is :{0}", s2.ToLower());
                        break;
                    case 7:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                       
                        Console.WriteLine("Old string s1 is :{0}", s1);
                        Console.WriteLine("New string after trim is :{0}", s1.Trim('g','o','o','d'));
                     
                        break;
                    case 8:
                        Console.WriteLine("Enter 1st string :");
                        s1 = Console.ReadLine();
                     
                        
                        Console.WriteLine("Old String is :{0}",s1);
                        
                        

                        String []str = s1.Split(',');
                        foreach (var k in str)
                        {
                            Console.WriteLine(" string after split :{0}", str);
                        }
                        // Console.WriteLine("split sthring :{0}",str);
                        break;
                    
                       





                    default:
                        Console.WriteLine("E   X   I   T");
                        break;
                }

            } while (true);

         
            
        }
    }
}
