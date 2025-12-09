using Tyuiu.UsoltsevGP.Sprint6.Task4.V8.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\Temp\OutPutFileTaskV8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
