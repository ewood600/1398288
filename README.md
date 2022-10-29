# 1398288

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¬вдите числа через зап€тую");
            Console.WriteLine("чЄ писать");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            foreach (var s in numbers)
            {
                int result = 0;
                if (!int.TryParse(s, out result))
                {
                    Console.WriteLine("ошибка, введите целые числа");
                }
                Console.ReadLine();
            }
        }
    }
}
