using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост (в метрах): ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес: ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

          //  Console.WriteLine(bmi);
         //   Console.ReadLine();

            if (bmi > 19 && bmi < 25)
            {
                Console.WriteLine("Ваш индекс массы тела {0:f2}. Ваш вес в порядке", bmi);
                Console.ReadLine();
            }
            else if (bmi < 19)
            {
                Console.WriteLine("Ваш индекс массы тела {0:f2}. Вам нужно набрать вес",bmi);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ваш индекс массы тела {0:f2}. Вам нужно сбросить вес",bmi);
                Console.ReadLine();
            }
        }
    }
}
