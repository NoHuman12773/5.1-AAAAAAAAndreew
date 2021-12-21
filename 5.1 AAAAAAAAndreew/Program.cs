using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_AAAAAAAAndreew
{
    class Program
    {
        static string desat(int n)
        {
            var s = string.Empty;
            while (n > 0)
            {
                s = (n % 2) + s;
                n /= 2;
            }
            return s;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число в десятичной системе: ");
            var n = int.Parse(Console.ReadLine());
            var s = desat(n);
            Console.WriteLine("{0} => {1}", n, s);
            Console.ReadLine();
        }
    }
}

