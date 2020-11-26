using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double c = double.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"Самое маленькое число равно {a}");
                Console.ReadLine();
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"Самое маленькое число равно {b}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\nСамое маленькое число равно {c}");
                Console.ReadLine();
            }
        }
    }
}
