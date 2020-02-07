
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod88()
        {
           
            TestContext.AddResultFile("C:\\agent\\trx.trx");
            System.Console.WriteLine("Trying to print something");
            Assert.AreEqual(1, 1);
            Assert.AreEqual(2, 2);

        }

        [TestMethod]
        public void TestMethod889()
        {
            System.Console.WriteLine("Writing something .......");
            Assert.AreEqual(1, 1);

        }
        [TestMethod]
        public void TestMethod90()
        {
            System.Console.WriteLine("Writing something .......");
            Assert.AreEqual(1, 1);

        }

        [TestMethod]
        public void TestMethod91()
        {
            System.Console.WriteLine("Writing something .......");
            Assert.AreEqual(1, 1);

        }

        [TestMethod]
        public void TestMethod92()
        {
            System.Console.WriteLine("Writing something .......");
            Assert.AreEqual(1, 1);

        }
        public TestContext TestContext { get; set; }
    }


}
