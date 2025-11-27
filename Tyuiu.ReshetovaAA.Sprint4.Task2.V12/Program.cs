using Tyuiu.ReshetovaAA.Sprint4.Task2.V12.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Решетова Арина | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный массив из 14 элементов, заполненный случайными числами   *");
            Console.WriteLine("* в диапазоне от 4 до 9. Найти сумму нечётных элементов массива.          *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[14];
            Random rnd = new Random();

            Console.WriteLine("* Сгенерированный массив:                                                 *");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(4, 10);
                Console.Write(array[i] + " ");
            }

            int result = ds.Calculate(array);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма нечётных элементов: {result}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу для выхода.                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}