using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
                int Loop = 0;
                UInt64 X;
                Console.WriteLine(" It is a program to view the sum of the nature numbers from 1 to X ");
                while (Loop == 0)
                {
                    try
                    {
                        Console.Write("Enter an Integer value of X : ");

                        X = Convert.ToUInt64(Console.ReadLine());

                        X = (X / 2) * (1 + X);

                        // You can prove this equation from the link : https://youtu.be/aaFrAFZATKU

                        Console.WriteLine("The result is : {0}", X);

                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Please enter a Whole number !!");

                    }
                }

            Console.ReadLine();
        }
    }
}
