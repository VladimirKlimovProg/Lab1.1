using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение m:");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Некорректный ввод. Необходимо целое число");
            }
            else
            {
                Console.WriteLine("Введите значение n:");
                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    Console.WriteLine("Некорректный ввод. Необходимо целое число");
                }
                else
                {
                    int result1 = n++ + m--;
                    Console.WriteLine($"Значение m: {m}. Значение n: {n}. Значение выражения n+++m--: {result1}");

                    bool result2 = n * m < n++;
                    Console.WriteLine($"Значение m: {m}. Значение n: {n}. Значение выражения n*m<n++: {result2}");

                    bool result3 = n-- > ++m;
                    Console.WriteLine($"Значение m: {m}. Значение n: {n}. Значение выражения n-->++m: {result2}");

                    Console.WriteLine("Введите значение x:");
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine("Некорректный ввод. Необходимо вещественное число. В качестве разделителя используйте запятую.");
                    }
                    else
                    {
                        double result4 = Math.Pow(2, x) * x * Math.Cos(x) + 1;
                        Console.WriteLine($"Значение выражения 2^x*x*cos(x)+1: {result4}");
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
