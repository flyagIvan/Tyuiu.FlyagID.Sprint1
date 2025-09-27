using Tyuiu.FlyagID.Sprint1.Task0.V5.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = (1 + 2) * (1 + 9 / 3);
            var res = ds.Calculate();
        }
    }
}
