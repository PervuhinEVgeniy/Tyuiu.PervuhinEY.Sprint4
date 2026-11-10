using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PervuhinEY.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int max = 0;
            int i = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
            return max;
            }
        }
    }

