using Exercise_1_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_1_CSharpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange

            // Act

            // Assert

            Assert.AreEqual("loquen", Exercise_1.Remove_char("eloquent"));
            Assert.AreEqual("ountr", Exercise_1.Remove_char("country"));
            Assert.AreEqual("erso", Exercise_1.Remove_char("person"));
            Assert.AreEqual("lac", Exercise_1.Remove_char("place"));
            Assert.AreEqual("", Exercise_1.Remove_char("ok"));
        }
    }
}