using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ReshetnikovaAA.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}