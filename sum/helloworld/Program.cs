using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int numberA = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            int numberB = int.Parse(Console.ReadLine());

            int sum = numberA + numberB;
            if (sum == 2) 
            {
                Console.WriteLine("Otvet 2");
            }
            else
            {
                Console.WriteLine(sum);
            }
            Console.WriteLine("Введите число C:");
            int numberC = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число D:");
            int numberD = int.Parse(Console.ReadLine());
            int sum2 = numberC + numberD;
            while (sum2 < 10) 
            {
                sum2 = numberC + numberD;
                Console.WriteLine(sum2);
                Console.WriteLine("Davai bolshe");
                Console.WriteLine("Введите число C:");
                numberC = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число D:");
                numberD = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Сумма чисел A и B равна: {sum}");


        }
    }
}
