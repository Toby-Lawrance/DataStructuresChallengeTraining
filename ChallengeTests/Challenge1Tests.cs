using System;
using Challenge;
using Xunit;

namespace ChallengeTests
{
    public class Challenge1Tests
    {
        [Theory]
        [InlineData("()",true)]
        [InlineData("(())",true)]
        [InlineData("(<>)",true)]
        [InlineData("((>)",false)]
        [InlineData("<<<((({{{[[[]]]}}})))>>>",true)]
        [InlineData("[>)()<>{}",false)]
        [InlineData("<>()[]{}",true)]
        [InlineData("<<>>(<>)[]",true)]
        [InlineData("<><><>)",false)]
        [InlineData("((<<[]>>)",false)]
        [InlineData("([)]",false)]
        public void Validation(string input, bool expected)
        {
            Assert.Equal(expected,Challenge1Class.Challenge1(input));
        }
    }
}