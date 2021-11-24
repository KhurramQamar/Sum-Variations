using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Sum()
        {
            int a = 7;int  b = 6;
            Console.WriteLine($"the sum of assigned integers {a} and {b} is: {a+b}");
           
        }
        static void Sum(int num1)
        {
            
            int sum = num1 + num1;
            Console.WriteLine($"the sum of itself {num1} is: {sum}");
        }
        nsole.WriteLine($"the sum of two float numbers  is: {a + b}");
        }
        static void Sum(double a, double b)
        {
            Console.WriteLine($"the sum of two double numbers  is: {a + b}");
        }
        static void Sum(string  a, string  b)
        {
            
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
