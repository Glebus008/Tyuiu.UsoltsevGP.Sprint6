using Tyuiu.UsoltsevGP.Sprint6.Task1.V2.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(2, 4);
            CollectionAssert.AreEqual(new double[] { 10.3, 16.17, 28.1 }, res);
        }
    }
}
