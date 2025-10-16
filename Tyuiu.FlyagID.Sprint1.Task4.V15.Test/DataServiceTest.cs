using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint1.Task4.V15.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2, 1);
            double expected = (2 + Math.Pow(1, 2)) / Math.Exp(2 - 4 * 1);
            Assert.AreEqual(expected, res, 0.0001);
        }
    }
}
