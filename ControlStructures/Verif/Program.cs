using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verif
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.Write("Введите логин: ");
                string log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string pass = Console.ReadLine();

                Verf(log, pass);
                i++;
            }
            while (i != 3);

            Console.WriteLine("Попытки закончились :(");
            Console.ReadLine();
        }

        static void Verf(string a, string b)
        {
            if (a == "root" && b == "GeekBrains")
            {
                Console.WriteLine("Поздравляем, авторизация прошла успешно!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Упс, что-то неверно :(");
                Console.ReadLine();
            }
        }
    }
}
