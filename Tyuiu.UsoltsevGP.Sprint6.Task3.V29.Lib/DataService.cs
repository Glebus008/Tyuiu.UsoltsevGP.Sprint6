using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UsoltsevGP.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] z = new int[5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                z[i] = matrix[i, 4];
            }
            Array.Sort(z);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 4] = z[i];
            }
            return matrix;
        }
    }
}
