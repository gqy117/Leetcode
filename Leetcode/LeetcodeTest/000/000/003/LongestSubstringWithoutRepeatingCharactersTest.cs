namespace LeetcodeTest
{
    using Leetcode;
    using NUnit.Framework;

    [TestFixture]
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        public void TwoSum_Default(string s, int expected)
        {
            this.ExecuteSolution(s, expected);
        }

        private void ExecuteSolution(string s, int expected)
        {
            // Act
            var actual = LongestSubstringWithoutRepeatingCharacters.Solution(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
