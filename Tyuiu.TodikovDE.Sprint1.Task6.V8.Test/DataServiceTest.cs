using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint1.Task6.V8.Lib;
namespace Tyuiu.TodikovDE.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "�����";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "���� �";
            Assert.AreEqual(wait, res);
        }
    }
}