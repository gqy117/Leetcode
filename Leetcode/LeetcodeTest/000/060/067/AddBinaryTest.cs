﻿namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class AddBinaryTest
    {
        [TestCase("11", "1", "100")]
        public void AddBinary_Default(string a, string b, string expected)
        {
            this.ExecuteSolution(a, b, expected);
        }

        [TestCase("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", 
            "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011",
            "110111101100010011000101110110100000011101000101011001000011011000001100011110011010010011000000000")]
        public void AddBinary_BigNumbers(string a, string b, string expected)
        {
            this.ExecuteSolution(a, b, expected);
        }

        private void ExecuteSolution(string a, string b, string expected)
        {
            // Act
            var actual = AddBinary.Solution(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
