using Tyuiu.UsoltsevGP.Sprint6.Task6.V11.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\InputFolder\InPutDataFileTask6V11.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}