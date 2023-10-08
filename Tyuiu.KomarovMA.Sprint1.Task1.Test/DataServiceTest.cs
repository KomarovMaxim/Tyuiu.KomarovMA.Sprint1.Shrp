using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint1.Task1.Lib;
namespace Tyuiu.KomarovMA.Sprint1.Task1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 4;
            double b = 2;
            double res = ds.Calculate(a, b);
            Assert.AreEqual(1.625, res);
        }
    }
}