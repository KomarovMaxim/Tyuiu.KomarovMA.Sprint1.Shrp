using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint1.Task0.Lib;
namespace Tyuiu.KomarovMA.Sprint1.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();

            Assert.AreEqual(0.6667, res, 0.0001);

        }
    }
}
