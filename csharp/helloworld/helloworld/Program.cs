using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            string greeting = "Hello";
            Console.WriteLine(greeting);
            double a, b, c;
            a = 10;
            b = Console.Read();
            Console.WriteLine(b);
            //a = 10 + b;
            Console.WriteLine(b);
            if (a == 20)
            {
                Console.WriteLine("Hello = " + a);
            }
            else
            {
                Console.WriteLine("a != 20" + a);
            }
            

        }
    }
}
