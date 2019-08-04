using Exercise_2_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_2_CSharpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SampleTest()
        {
            // Arrange
            var sheeps = new[] { true, false, true };
            var expected = 2;

            // Act
            var actual = Exercise_2.CountSheeps(sheeps);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
