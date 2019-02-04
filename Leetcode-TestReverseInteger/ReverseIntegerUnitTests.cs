using System;
using Xunit;
using LeetCode_ReverseInteger;
namespace Leetcode_TestReverseInteger
{
    public class ReverseIntegerUnitTests
    {
        [Fact]
        public void PostiveNumber()
        {
            int result = ReverseInteger.Reverse(8734);
            Assert.Equal(4378, result);
        }

        [Fact]
        public void NegativeNumber()
        {
            int result = ReverseInteger.Reverse(-8734);
            Assert.Equal(-4378, result);
        }

        [Fact]
        public void NegativeNumberBorderline()
        {
            int result = ReverseInteger.Reverse(-2147483648);
            Assert.Equal(0, result);
        }

        [Fact]
        public void PositiveNumberBorderline()
        {
            int result = ReverseInteger.Reverse(2147483647);
            Assert.Equal(0, result);
        }
    }
}