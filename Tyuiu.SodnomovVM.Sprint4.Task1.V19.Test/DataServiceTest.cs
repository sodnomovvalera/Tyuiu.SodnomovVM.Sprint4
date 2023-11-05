using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SodnomovVM.Sprint4.Task1.V19.Lib;

namespace Tyuiu.SodnomovVM.Sprint4.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 1,2,3,4};
            int sum = 6;
            int result = ds.Calculate(a);
            Assert.AreEqual(sum, result);

        }
    }
}
