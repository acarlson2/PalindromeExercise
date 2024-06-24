using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tacocat", true)]
        [InlineData("goatmeat", false)]
        [InlineData("hannah", true)]
        [InlineData("dogdog", false)]
        public void Test1(string str, bool expected)
        {
            WordSmith wordSmith = new WordSmith();

            bool actual = wordSmith.IsAPalindrome(str);

            Assert.Equal(expected, actual);
        }
    }
}
