using Tyuiu.UsoltsevGP.Sprint6.Task7.V7.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Task7\InPutDataFileTask7V7.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
