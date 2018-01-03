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
            Assert.AreEqual(1, Solution.FirstMissingPositive(new int[] { 0 }));
        }

        [TestMethod]
        public void Input_1_Should_Be_2()
        {
            Assert.AreEqual(2, Solution.FirstMissingPositive(new int[] { 1 }));
        }

        [TestMethod]
        public void Input_f1_Should_Be_1()
        {
            Assert.AreEqual(1, Solution.FirstMissingPositive(new int[] { -1 }));
        }

        [TestMethod]
        public void Input_f2f3and5and6_Should_Be_1()
        {
            Assert.AreEqual(1, Solution.FirstMissingPositive(new int[] { -2, -3, 5, 6 }));
        }

        [TestMethod]
        public void Input_1n2n3n4_Should_Be_5()
        {
            Assert.AreEqual(5, Solution.FirstMissingPositive(new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void Input_1n6n5()
        {
            Assert.AreEqual(2, Solution.FirstMissingPositive(new int[] { 1, 6, 5 }));}

    }

    public class Solution
    {
        public static int FirstMissingPositive(int[] nums)
        {
            if (nums.Length < 1)
            {
                return 1;
            }
            for (int i = 1; i <= nums.Max() + 1; i++)
            {
                if (!nums.Contains(i))
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
