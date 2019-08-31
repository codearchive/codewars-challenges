using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_3_CSharp.Test
{
    [TestClass]
    public class ArgeTest
    {
        [TestMethod]
        public void NbYearTest()
        {
            // Arrange

            // Act

            // Assert
            Console.WriteLine("Testing NbYear");
            Assert.AreEqual(Arge.NbYear(1500, 5, 100, 5000),15);
            Assert.AreEqual(Arge.NbYear(1500000, 2.5, 10000, 2000000), 10);
            Assert.AreEqual(Arge.NbYear(1500000, 0.25, 1000, 2000000), 94);
        }
    }
}
