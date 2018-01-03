using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_ReverseInteger
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_null_Should_Be_1()
        {
            Assert.AreEqual(1,Solution.FirstMissingPositive(new int[]{}));
        }
    }

    public class Solution
    {
        public static int FirstMissingPositive(int[] nums)
        {
            throw new NotImplementedException();
        }
    }
}
