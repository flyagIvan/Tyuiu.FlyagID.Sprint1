using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint1.Task6.V7.Lib;

namespace Tyuiu.FlyagID.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestDeleteLastLetter_NormalInput()
        {
            DataService ds = new DataService();

            string input = "Привет мир сегодня";
            string expected = "Приве ми сегодн";
            string result = ds.DeleteLastLetter(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDeleteLastLetter_SingleLetterWords()
        {
            DataService ds = new DataService();

            string input = "А я и о";
            string expected = "";
            string result = ds.DeleteLastLetter(input);

            Assert.AreEqual(expected, result);
        }
    }
}