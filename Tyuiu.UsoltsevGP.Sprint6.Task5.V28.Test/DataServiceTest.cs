using Tyuiu.UsoltsevGP.Sprint6.Task5.V28.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\InputFolder\InPutDataFileTask5V28.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
