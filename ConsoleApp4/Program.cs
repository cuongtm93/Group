using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var y = new Z2Group();
            Console.WriteLine("e= " + y.Identity());
            foreach (var item in y.SET)
            {
                Console.WriteLine($"{item}^-1 = {y.Inverse(item)}");
            }
            Console.WriteLine("IsGroup : " + y.IsGroup());
            Console.ReadLine();
        }
    }
}
