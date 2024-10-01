using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint1.Task1.V6.Lib;
namespace Tyuiu.TodikovDE.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}