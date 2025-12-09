using Tyuiu.UsoltsevGP.Sprint6.Task3.V29.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mass = new int[5, 5] { { -2, -13, -15, -9, -17 }, { 13, -20, -15, 27, 18 }, { -12, -1, -20, 13, 0 }, { 15, 32, 18, -12, -18 }, { 16, 5, 3, -5, -8 } };
            int[,] res = new int[5, 5];
            res = ds.Calculate(mass);
            int[,] wait = new int[5, 5] { { -2, -13, -15, -9, -18 }, { 13, -20, -15, 27, -17 }, { -12, -1, -20, 13, -8 }, { 15, 32, 18, -12, 0 }, { 16, 5, 3, -5, 18 } };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
