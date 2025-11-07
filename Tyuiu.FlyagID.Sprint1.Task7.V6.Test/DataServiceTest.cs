using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint1.Task7.V6.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateExample()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 1;
            double expected = Math.Round(Math.Pow(1 + 1 / Math.Pow(2, 2), 2) - 12 * Math.Pow(2, 2) * 1, 3);
            double result = ds.Calculate(x, y);

            Assert.AreEqual(expected, result);
        }
    }
}