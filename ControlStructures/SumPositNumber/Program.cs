using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPositNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            double sum = 0;

            do // выполнять
            {
                Console.WriteLine("Введите число");
                num = double.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 0) //проверка на положительность и чётность
                sum += num;
            }
            while (num != 0); //пока num не 0

            Console.WriteLine($"Сумма чётных чисел равна: {sum}");
            Console.ReadLine();
        }
    }
}
