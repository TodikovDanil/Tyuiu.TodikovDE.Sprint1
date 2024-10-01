using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint1.Task4.V25.Lib;
namespace Tyuiu.TodikovDE.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait =0.649;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}