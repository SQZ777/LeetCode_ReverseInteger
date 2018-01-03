using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_ReverseInteger
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_null_Should_Be_1()
        {
            Assert.AreEqual(1, Solution.FirstMissingPositive(new int[] { }));
        }

        [TestMethod]
        public void Input_0_Should_Be_1()
        {
            Assert.AreEqual(1,Solution.FirstMissingPositive(new int[]{1}));
        }

    }

    public class Solution
    {
        public static int FirstMissingPositive(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 1;
            }
            return 1;
        }
    }
}
