using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b (b > a)");
            int b = int.Parse(Console.ReadLine());

            Rec(a,b);

            static void Rec(int A, int B)
            {
                Console.Write(" " + A);
                if ( A < B) Rec(A + 1, B);
                Console.ReadLine();
            }
        }
    }
}
