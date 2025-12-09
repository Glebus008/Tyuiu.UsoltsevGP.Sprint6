using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UsoltsevGP.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            string[] firstLineValues = lines[0].Split(';');
            int columns = firstLineValues.Length;
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            if (rows > 4)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[4, j] % 2 != 0)
                    {
                        matrix[4, j] = 66;
                    }
                }
            }

            return matrix;
        }
    }
}