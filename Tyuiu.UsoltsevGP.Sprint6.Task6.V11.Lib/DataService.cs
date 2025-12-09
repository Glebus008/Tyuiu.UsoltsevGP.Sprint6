using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.UsoltsevGP.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            StringBuilder result = new StringBuilder();

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Разделяем строку на слова, игнорируя пустые элементы
                        string[] words = line.Split(new char[] { ' ', '\t' },
                                                    StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length >= 2)
                        {
                            // Предпоследнее слово (длина-2)
                            result.Append(words[words.Length - 2]);
                            result.Append(" ");
                        }
                        // Если меньше 2 слов - пропускаем строку
                    }
                }

                // Убираем последний пробел, если он есть
                if (result.Length > 0)
                {
                    result.Length--;
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}", ex);
            }
        }
    }
}