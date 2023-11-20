using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDD
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.AreEqual(10, five.amount);
        }
    }
}
