using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 238;
            int b = 345;
            int min = Math.Min(a, b);
            if (min == a)
            {
                Console.WriteLine("b is the biggest number: " + b);
            }
            else
            {
                Console.WriteLine("a is biggest number: " + a);
            }
        }
    }
}
