using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint1.V13.Lib;
namespace Tyuiu.KomarovMA.Sprint1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertMilesToKm1()
        {
            DataService ds = new DataService();
            int m = 1;
            double res = ds.ConvertMilesToKm(m);

            Assert.AreEqual(0.6215, res, 0.0001);
        }
    }
}
