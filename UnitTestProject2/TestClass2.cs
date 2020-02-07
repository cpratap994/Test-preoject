using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class TestClass2
    {

        static IEnumerable<object[]> ReusableTestDataProperty
        {
            get
            {
                return new[]
                {
                new object[] {1, 2, 3},
                new object[] {4, 5, 6},
                new object[] {7, 8, 9},
                new object[] {10, 11, 1}
            };
            }
        }

        static IEnumerable<object[]> ReusableTestDataMethod()
        {
            return new[]
            {
            new object[] {1, 2, 3},
            new object[] {4, 5, 6},
            new object[] {7, 8, 9},
            new object[] {10, 11, 12},
            new object[] {13, 14, 15},
            new object[] {13, 14, 13},
        };
        }

        // Property ReusableTestDataProperty can be used as data source for test data with data driven test case.
        [TestMethod]
        [DynamicData("ReusableTestDataProperty")]
        public void DynamicDataTestMethod1(int a, int b, int c)
        {
            Assert.AreEqual(1, a % 3);
            Assert.AreEqual(2, b % 3);
            Assert.AreEqual(0, c % 3);
        }

        // Method ReusableTestDataMethod can be used as data source for test data with data driven test case.
        [TestMethod]
        [DynamicData("ReusableTestDataMethod", DynamicDataSourceType.Method)]
        public void DynamicDataTestMethod2(int a, int b, int c)
        {
            Assert.AreEqual(1, a % 3);
            Assert.AreEqual(2, b % 3);
            Assert.AreEqual(0, c % 3);
        }
    }


}
