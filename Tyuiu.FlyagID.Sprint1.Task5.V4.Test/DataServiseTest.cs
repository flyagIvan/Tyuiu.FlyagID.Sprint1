using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint1.Task5.V4.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestSecondsToHoursExample()
        {
            DataService ds = new DataService();

            int k = 13257;
            int expected = 3;
            int result = ds.SecondsToHours(k);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBoundaryValues()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0, ds.SecondsToHours(3599));  // до 1 часа
            Assert.AreEqual(1, ds.SecondsToHours(3600));  // ровно 1 час
            Assert.AreEqual(23, ds.SecondsToHours(86399)); // почти сутки
        }
    }
}