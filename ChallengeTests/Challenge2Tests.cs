using System;
using System.Collections.Generic;
using Challenge;
using Xunit;

namespace ChallengeTests
{
    public class Challenge2Tests
    {
        [Theory]
        [ClassData(typeof(Challenge2GeneratorDoNotPeek))]
        public void Validation(IEnumerable<Challenge2Class.Person> people, int expected)
        {
            Assert.Equal(expected,Challenge2Class.Challenge2(people));
        }
        
        
    }
}