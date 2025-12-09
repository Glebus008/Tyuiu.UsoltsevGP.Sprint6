using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UsoltsevGP.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                throw new ArgumentException("Начальное значение не может быть больше конечного");
            }

            // Вычисляем размер массива
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            // Табулирование функции
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Знаменатель: sin(x) + 2
                double denominator = Math.Sin(x) + 2;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.0001) // или denominator == 0
                {
                    valueArray[count] = 0;
                }
                else
                {
                    // Вычисление функции: F(x) = (5x + 2.5) / (sin(x) + 2) + 2x + 2
                    valueArray[count] = (5 * x + 2.5) / denominator + 2 * x + 2;

                    // Округление до 2 знаков после запятой
                    valueArray[count] = Math.Round(valueArray[count], 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}