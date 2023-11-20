using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDD
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.times(2));
            Assert.AreEqual(new Dollar(15), five.times(3));
        }

        [TestMethod]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
