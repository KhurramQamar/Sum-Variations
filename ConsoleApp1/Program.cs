using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
       
        static void  Sum(int a,int b)
        {
             Console.WriteLine($"the sum of two integers  is: {a+b}");
        }
        static void Sum(float a, float b)
        {
            Console.WriteLine($"the sum of two float numbers  is: {a + b}");
        }
        static void Sum(double a, double b)
        {
            Console.WriteLine($"the sum of two double numbers  is: {a + b}");
        }
        static void Sum(string  a, string  b)
        {
            Console.WriteLine($"the sum of two string is: {a + b}");
        }

        static void Main(string[] args)

        {
            Sum();
            Sum(2);
            Sum(2, 2);
            Sum(2.2, 2.2);
            Sum("FC", "IT");
        }
    }
}
