using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, в котором будем чистать символы: ");
            int num = Console.ReadLine().Length;

            Console.WriteLine($"Количество символов равно {num}");
            Console.ReadLine();
        }
    }
}
