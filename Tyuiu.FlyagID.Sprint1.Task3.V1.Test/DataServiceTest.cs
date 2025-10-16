using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint1.Task3.V1.Lib;
using System;

namespace Tyuiu.FlyagID.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double radius = 3.0;
            double height = 5.0;

            double result = ds.CylinderVolume(radius, height);
            double expected = Math.Round(Math.PI * Math.Pow(radius, 2) * height, 3);

            Assert.AreEqual(expected, result);
        }
    }
}