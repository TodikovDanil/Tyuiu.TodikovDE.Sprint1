using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint1.Task5.V1.Lib;
namespace Tyuiu.TodikovDE.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 2;
            double y1 = 4;
            double x2 = 5;
            double y2 = 6;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1,y1,y2,x2);
            
            int result =  Convert.ToInt32(res);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}