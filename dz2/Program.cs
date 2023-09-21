using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1");
            string name;
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Добрый вечер, {name}");
            Console.WriteLine("Упражнение 2.2");
            int x, y;
            Console.WriteLine("Введите x: ");
            Console.WriteLine("Введите y: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"{x / y}");
            }
            Console.WriteLine("Домашнее задание 2.1");
            Console.WriteLine("Введите букву");
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'z')
                Console.WriteLine("a");
            else
                Console.WriteLine((char)(letter + 1));
            Console.WriteLine("Домашнее задание 2.2");
            double a, b, c, x1, x2;
            Console.WriteLine("Введите a : ");
            Console.WriteLine("Введите b : ");
            Console.WriteLine("Введите c : ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (b * b - 4 * a * c >= 0)
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}