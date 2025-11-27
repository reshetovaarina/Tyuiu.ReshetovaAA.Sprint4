using Tyuiu.ReshetovaAA.Sprint4.Task1.V25.Lib;

namespace Tyuiu.ReshetovaAA.Sprint4.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Решетова А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 14 элементов, вводимый с клавиатуры (1–7).                *");
            Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                            *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[14];

            Console.WriteLine("Введите 14 чисел через Enter:");

            for (int i = 0; i < 14; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма чётных элементов = {result}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу для выхода.                 *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}