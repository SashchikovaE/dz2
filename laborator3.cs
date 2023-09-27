using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Student
{
    public string LastName;
    public string FirstName;
    public int Id;
    public DateTime DateOfBirth;
    public char AlcoholCategory;
    public double AlcoholVolume; 
}
namespace laborator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("sbyte\t{0}\t{1}", sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("byte\t{0}\t{1}", byte.MaxValue, byte.MinValue);
            Console.WriteLine("short\t{0}\t{1}", short.MaxValue, short.MinValue);
            Console.WriteLine("ushort\t{0}\t{1}", ushort.MaxValue, ushort.MinValue);
            Console.WriteLine("int\t{0}\t{1}", int.MaxValue, int.MinValue);
            Console.WriteLine("uint\t{0}\t{1}", uint.MaxValue, uint.MinValue);
            Console.WriteLine("long\t{0}\t{1}", long.MaxValue, long.MinValue);
            Console.WriteLine("ulong\t{0}\t{1}", ulong.MaxValue, ulong.MinValue);
            Console.WriteLine("float\t{0}\t{1}", float.MaxValue, float.MinValue);
            Console.WriteLine("double\t{0}\t{1}", double.MaxValue, double.MinValue);
            Console.WriteLine("decimal\t{0}\t{1}", decimal.MaxValue, decimal.MinValue);

        Console.WriteLine("задание 2");
            string name, city, pincode;
            int age;
            Console.WriteLine("Введите ваше имя: ");
            Console.WriteLine("Введите ваш город: ");
            Console.WriteLine("Введите ваш возраст: ");
            Console.WriteLine("Введите ваш PIN-код: ");
            name = Console.ReadLine();
            city = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            pincode = Console.ReadLine();
            Console.WriteLine("Имя: {0}", name);
            Console.WriteLine("Город: {0}", city);
            Console.WriteLine("Возраст: {0}", age);
            Console.WriteLine("PIN-код: {0}", pincode);

            Console.WriteLine("Задание 3");
            string liza;
            Console.Write("Введите строку: ");
            liza = Console.ReadLine();
            liza = liza.ToUpper();
            Console.WriteLine("Полученная строка " + liza);
      
            Console.WriteLine("Задание 6");
            Console.WriteLine("Привет! Как тебя зовут?");
            string Name = Console.ReadLine();
            Console.WriteLine($"Привет, {Name}!");
            Console.WriteLine("Знаешь ли ты что-то о тайной комнате?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "да")
            {
                Console.WriteLine("Могу показать, но не могу рассказать.");
                Thread.Sleep(5000);
                Random random = new Random();
                Console.BackgroundColor = (ConsoleColor)random.Next(1, 16);
                Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
                Console.WriteLine("Пожалуйста, посмотри на экран!");
            }
            else
            {
                Console.WriteLine("К сожалению, я не знаю ничего про тайную комнату.");
            }
            
            Console.WriteLine("Задание 8");
            Student[] students = new Student[5];

            students[0].LastName = "Stepanova";
            students[0].FirstName = "Anastasia";
            students[0].Id = 1;
            students[0].DateOfBirth = new DateTime(2005, 09, 05);
            students[0].AlcoholCategory = 'a';
            students[0].AlcoholVolume = 100;

            students[1].LastName = "Volostnov";
            students[1].FirstName = "Daniel";
            students[1].Id = 2;
            students[1].DateOfBirth = new DateTime(2005, 07, 17);
            students[1].AlcoholCategory = 'b';
            students[1].AlcoholVolume = 50;

            students[2].LastName = "Leshchenko";
            students[2].FirstName = "Ilya";
            students[2].Id = 3;
            students[2].DateOfBirth = new DateTime(2005, 11, 28);
            students[2].AlcoholCategory = 'c';
            students[2].AlcoholVolume = 200;

            students[3].LastName = "Beker";
            students[3].FirstName = "Diana";
            students[3].Id = 4;
            students[3].DateOfBirth = new DateTime(2004, 04, 12);
            students[3].AlcoholCategory = 'd';
            students[3].AlcoholVolume = 0;

            students[4].LastName = "Shakirova";
            students[4].FirstName = "Kamilya";
            students[4].Id = 5;
            students[4].DateOfBirth = new DateTime(2005, 01, 07);
            students[4].AlcoholCategory = 'b';
            students[4].AlcoholVolume = 100;
            double totalAlcoholVolume = 0;

            for (int i = 0; i < students.Length; i++)
            {
                totalAlcoholVolume += students[i].AlcoholVolume;
            }
            for (int i = 0; i < students.Length; i++)
            {
                double percent = students[i].AlcoholVolume / totalAlcoholVolume * 100;
                Console.WriteLine("{0} {1} выпил {2} мл алкоголя, что составляет {3:0.0}% от общего объема.",
                    students[i].LastName, students[i].FirstName, students[i].AlcoholVolume, percent);
            }
            Console.ReadKey();
        }
    }
}