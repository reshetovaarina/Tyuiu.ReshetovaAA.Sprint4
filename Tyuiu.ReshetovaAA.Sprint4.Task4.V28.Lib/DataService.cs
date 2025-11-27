using System;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ReshetovaAA.Sprint4.Task4.V28.Lib
{
    public class DataService : ISprint4Task4V28
    {
        public int[,] Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        result[i, j] = 1;
                    }
                    else
                    {
                        result[i, j] = array[i, j];
                    }
                }
            }

            return result;
        }
    }
}