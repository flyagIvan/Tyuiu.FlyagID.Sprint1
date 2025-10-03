using Tyuiu.FlyagID.Sprint1.Task1.V26.Lib;
namespace Tyuiu.FlyagID.Sprint1.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2; int y = 3;
            var res= ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
