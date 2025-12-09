using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UsoltsevGP.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = Math.Abs(startValue) + stopValue + 1;
            int count = 0;
            double[] res = new double[len];
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((2 - i) == 0)
                {
                    res[count] = 0;
                }
                else
                {
                    res[count] = Math.Sin(i) + (Math.Cos(i) + 1) / (2 - i) + 2 * i;
                    res[count] = Math.Round((res[count]), 2);
                }
                count++;

            }
            return res;
        }
    }
}
