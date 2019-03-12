using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слогаемое!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе слогаемое!");
            int b = Convert.ToInt32(Console.ReadLine());
            int res = MathOperations.CubSumi(a, b);

            Console.WriteLine("результат: " + res);

            Console.ReadKey();
        }
    }

    class MathOperations
    {
        public static int CubSumi(int arg1, int arg2)
        {
            int sum = arg1 + arg2;
            return sum * sum * sum;
        }
    }
}