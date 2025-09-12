using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZjatkovDV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ZjatkovDV.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionlValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationlValid()
        {
            Assert.AreEqual(50, DataService.Multiplicatio(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionlValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
