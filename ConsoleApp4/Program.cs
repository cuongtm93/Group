using System;

namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            var g = new Z2Group();
            Console.WriteLine("e= " + g.Identity());
            foreach (var item in g.SET)
            {
                Console.WriteLine($"{item}^-1 = {g.Inverse(item)}");
            }


            Console.WriteLine("IsGroup : " + g.IsGroup());

            // tính chất trên nhóm (a*b)^-1 = (b^-1) * (a^-1);
            Console.WriteLine(g.Inverse(g.Operator(Symbol.a,Symbol.b)) == g.Operator(g.Inverse(Symbol.b),g.Inverse(Symbol.a)));
            
            Console.ReadLine();
        }
    }
}
