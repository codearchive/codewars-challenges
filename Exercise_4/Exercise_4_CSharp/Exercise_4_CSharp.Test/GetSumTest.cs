using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_4_CSharp.Test
{
    [TestClass]
    public class GetSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            
            // Act
            
            // Assert
            Assert.AreEqual(1, Sum.GetSum(0, 1));
            Assert.AreEqual(-1, Sum.GetSum(0, -1));
            Assert.AreEqual(10, Sum.GetSum(1, 4));
            Assert.AreEqual(10, Sum.GetSum(4, 1));
            Assert.AreEqual(0, Sum.GetSum(3, -3));
        }
    }
}
