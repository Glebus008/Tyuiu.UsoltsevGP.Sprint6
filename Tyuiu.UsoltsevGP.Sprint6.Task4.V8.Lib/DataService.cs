using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UsoltsevGP.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] m = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 - x != 0)
                {
                    m[count++] = Math.Round(Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x, 2);
                }
                else
                {
                    m[count++] = 0;
                }
            }
            return m;
        }
    }
}
