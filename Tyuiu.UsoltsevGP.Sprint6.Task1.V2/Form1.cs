using Tyuiu.UsoltsevGP.Sprint6.Task1.V2.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task1.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBox4.Text);
                int stopStep = int.Parse(textBox5.Text);

                if (startStep > stopStep)
                {
                    textBox6.Text = "Ошибка: Стартовый шаг не может быть больше конечного!";
                    return;
                }

                DataService ds = new DataService();
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                // Очищаем поле
                textBox6.Text = "";

                // Заголовок таблицы
                textBox6.AppendText("+----------+----------+" + Environment.NewLine);
                textBox6.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBox6.AppendText("+----------+----------+" + Environment.NewLine);

                // Вывод данных
                for (int i = 0; i < valueArray.Length; i++)
                {
                    int x = startStep + i;
                    // Используем запятую как десятичный разделитель (русский формат)
                    string formattedValue = valueArray[i].ToString("F2").Replace('.', ',');

                    // Форматирование с фиксированной шириной
                    string line = $"|{x,6}    |{formattedValue,9} |";
                    textBox6.AppendText(line + Environment.NewLine);
                }

                textBox6.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch (FormatException)
            {
                textBox6.Text = "Ошибка: Введите целые числа!";
            }
            catch (Exception ex)
            {
                textBox6.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = "Введите начало и конец диапазона, затем нажмите 'Выполнить'";
        }
    }
}