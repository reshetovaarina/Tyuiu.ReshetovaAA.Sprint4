using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ReshetovaAA.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int row = 2; 
            int max = array[row, 0];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row, j] > max)
                {
                    max = array[row, j];
                }
            }

            return max;
        }
    }
}