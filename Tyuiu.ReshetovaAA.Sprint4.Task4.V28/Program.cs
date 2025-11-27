using System;
using Tyuiu.ReshetovaAA.Sprint4.Task4.V28.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task 4 | Вариант 28 | Решетова А.А.";

            DataService ds = new DataService();

            int[,] array = new int[,]
            {
                { 3, 3, 1, 1, 4 },
                { 2, 4, 2, 1, 5 },
                { 2, 2, 2, 2, 2 },
                { 1, 5, 4, 5, 4 },
                { 1, 2, 3, 2, 4 }
            };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            int[,] result = ds.Calculate(array);

            Console.WriteLine("\nРезультат:");
            PrintArray(result);

            Console.ReadKey();
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}