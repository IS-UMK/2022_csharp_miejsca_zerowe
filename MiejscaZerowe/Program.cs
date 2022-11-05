using System;

namespace MiejscaZerowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2;
            double delta;

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"y = {a} x^2 + {b} x + {c} ");

            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                x1 = -(b - Math.Sqrt(delta)) / (2 * a);
                x2 = -(b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = {0,10:F3}", x1);
                Console.WriteLine("x2 = {0,10:F3}", x2);
            }
            else if (delta < 0)
            {
                Console.WriteLine("Brak miejsc zerowych");
            }
            else
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = {0,10:F3}", x1);
            }
        }
    }
}
