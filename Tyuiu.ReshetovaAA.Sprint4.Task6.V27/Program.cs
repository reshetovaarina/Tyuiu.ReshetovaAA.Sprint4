using System;
using Tyuiu.ReshetovaAA.Sprint4.Task6.V27.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #4 | Таск 6 | Вариант 27";
            Console.Title = "Спринт #4 | Выполнила: Решетова Арина | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");

            string[] shapes =
            {
                "Квадрат", "Прямоугольник", "Круг", "Треугольник",
                "Пятиугольник", "Шестиугольник", "Восьмиугольник"
            };

            Console.WriteLine("Исходный массив:\n");

            foreach (var item in shapes)
            {
                Console.WriteLine(item);
            }

            DataService ds = new DataService();
            int result = ds.Calculate(shapes);

            Console.WriteLine($"\nКоличество элементов, длина которых < 7: {result}");
        }
    }
}