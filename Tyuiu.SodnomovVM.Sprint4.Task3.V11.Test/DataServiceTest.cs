using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SodnomovVM.Sprint4.Task3.V11.Lib;

namespace Tyuiu.SodnomovVM.Sprint4.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] massive = { { 1, 2, 3, 4, 2 }, 
                               { 5, 6, 7, 8, 2 }, { 1, 2, 3, 4, 2 },
                               { 5, 6, 7, 8, 2 }, { 1, 2, 3, 4, 2 },};

            int ozhid = 10;

            int rezult = ds.Calculate(massive);
            Assert.AreEqual(ozhid, rezult);
        }
    }
}
