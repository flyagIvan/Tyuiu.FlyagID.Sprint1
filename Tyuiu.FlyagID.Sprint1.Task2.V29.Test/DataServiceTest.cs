using Tyuiu.FlyagID.Sprint1.Task2.V29.Lib;
namespace Tyuiu.FlyagID.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertSecondsToHours(x);
            Assert.AreEqual(120, res);
        }
    }
}
