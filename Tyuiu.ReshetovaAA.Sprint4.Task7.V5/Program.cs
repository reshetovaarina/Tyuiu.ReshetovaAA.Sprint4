using System;
using Tyuiu.ReshetovaAA.Sprint4.Task7.V5.Lib;
namespace Tyuiu.ReshetovaAA.Sprint4.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Решетова А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр .                                     *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3.Подсчитать количество четных чисел.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int columns = 3;
            string str = "246813579"; 

            DataService ds = new DataService();

            int index = 0;


            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(str[index] + "\t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n********* РЕЗУЛЬТАТ *********");

            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine("Количество чётных элементов = " + res);

            Console.ReadKey();
        }
    }
}