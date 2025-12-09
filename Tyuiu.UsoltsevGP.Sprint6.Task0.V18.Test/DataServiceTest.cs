using Tyuiu.UsoltsevGP.Sprint6.Task0.V18.Lib;
namespace Tyuiu.UsoltsevGP.Sprint6.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1.056;
            Assert.AreEqual(wait, res);
        }
    }
}
