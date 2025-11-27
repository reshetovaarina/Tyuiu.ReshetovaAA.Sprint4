using System;
using Tyuiu.ReshetnikovaAA.Sprint4.Task4.V27.Lib;

namespace Tyuiu.ReshetnikovaAA.Sprint4.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Задача 4 | Вариант 27";

            DataService ds = new DataService();

            Random rnd = new Random();
            int[,] array = new int[5, 5];

            Console.WriteLine("Сгенерированный массив (числа от -5 до 7):\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(-5, 8);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(array);

            Console.WriteLine("\nКоличество отрицательных элементов: " + result);
        }
    }
}