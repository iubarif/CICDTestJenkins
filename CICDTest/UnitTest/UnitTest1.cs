using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2 ,2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
