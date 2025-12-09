using Tyuiu.UsoltsevGP.Sprint6.Task6.V11.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Создаём временный файл для теста
            string testPath = @"TestFileTask6V11.txt";

            // Тестовые данные
            string testContent = "Первая строка с несколькими словами\n" +
                                "Вторая строка\n" +
                                "Третья строка имеет больше двух слов\n" +
                                "Четвертая\n" + // Эта строка будет пропущена (меньше 2 слов)
                                "Пятая и последняя строка";

            File.WriteAllText(testPath, testContent);

            try
            {
                string result = ds.CollectTextFromFile(testPath);
                string expected = "несколькими строка больше и";

                Assert.AreEqual(expected, result);
            }
            finally
            {
                // Удаляем временный файл
                if (File.Exists(testPath))
                {
                    File.Delete(testPath);
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFoundCollectTextFromFile()
        {
            DataService ds = new DataService();
            string nonExistentPath = @"C:\NonExistentFolder\NonExistentFile.txt";

            ds.CollectTextFromFile(nonExistentPath);
        }

        [TestMethod]
        public void EmptyFileCollectTextFromFile()
        {
            DataService ds = new DataService();
            string testPath = @"EmptyFileTask6V11.txt";

            File.WriteAllText(testPath, "");

            try
            {
                string result = ds.CollectTextFromFile(testPath);
                Assert.AreEqual("", result);
            }
            finally
            {
                if (File.Exists(testPath))
                {
                    File.Delete(testPath);
                }
            }
        }

        [TestMethod]
        public void SingleWordLinesCollectTextFromFile()
        {
            DataService ds = new DataService();
            string testPath = @"SingleWordFile.txt";

            string testContent = "Один\nДва\nТри";
            File.WriteAllText(testPath, testContent);

            try
            {
                string result = ds.CollectTextFromFile(testPath);
                // Все строки содержат по 1 слову, поэтому ничего не должно быть добавлено
                Assert.AreEqual("", result);
            }
            finally
            {
                if (File.Exists(testPath))
                {
                    File.Delete(testPath);
                }
            }
        }
    }
}