using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OzowDev;

namespace SortUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Sort.SortString("");
            Assert.AreEqual(result, "Input is required");
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "Contrary to popular belief, the pink unicorn flies east.";
            var result = Sort.SortString(input);
            Assert.AreEqual(result, "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy");
        }
    }
}
