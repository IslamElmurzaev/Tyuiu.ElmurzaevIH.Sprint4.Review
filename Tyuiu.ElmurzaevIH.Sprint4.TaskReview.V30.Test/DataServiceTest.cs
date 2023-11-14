using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using Tyuiu.ElmurzaevIH.Sprint4.TaskReview.V30.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint4.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            
            string str = "684259137159648";
            
            int res = ds.Calculate(5, 3, str);
            int expected = 73728;

            Assert.AreEqual(expected, res);
        }
    }
}
