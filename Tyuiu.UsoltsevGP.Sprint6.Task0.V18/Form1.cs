using Tyuiu.UsoltsevGP.Sprint6.Task0.V18.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task0.V18
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
                // Получаем значение X из textBox4 (пустое поле рядом с "Переменная X:")
                int x = int.Parse(textBox4.Text);

                // Проверка деления на ноль
                if (x == 0)
                {
                    MessageBox.Show("Ошибка: X не может быть 0 (деление на ноль)!",
                                    "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Вычисляем по формуле y(x) = (x³ - 8) / (2x²)
                DataService ds = new DataService();
                double result = ds.Calculate(x);

                // Выводим результат в textBox5 (пустое поле под "Результат:")
                textBox5.Text = result.ToString("F3"); // 3 знака после запятой
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода! Введите целое число в поле X.",
                                "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Кнопка с вопросом (очистка)
            // Очищаем поле ввода и результат
            textBox4.Clear();
            textBox5.Clear();
            textBox4.Focus(); // Фокус на поле ввода X
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}