using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SodnomovVM.Sprint4.Task0.V2.Lib;

namespace Tyuiu.SodnomovVM.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
           
            DataService ds = new DataService();
            int[] a = { 1, 2, 4, 6, 8, 2,7, 4, 6, 7 };
            int sum = 15;
            int result = ds.GetSumOddArrEl(a);
            Assert.AreEqual(sum, result);

        }
    }
}
