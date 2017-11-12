using System;
using HackerRank.CrackingTheCodingInterview;
using Xunit;

namespace HackerRank.Tests.CrackingTheCodingInterview
{
    public class LeftRotationTests
    {
        private readonly LeftRotation _sut;

        public LeftRotationTests()
        {
            _sut = new LeftRotation();
        }

        [Fact]
        public void Sample()
        {
            var input = Array.ConvertAll("1 2 3 4 5".Split(' '), int.Parse);
            var rotation = 4;

            var actual = _sut.RotateLeft(input, rotation);

            Assert.Equal(5, actual[0]);
            Assert.Equal(1, actual[1]);
            Assert.Equal(2, actual[2]);
            Assert.Equal(3, actual[3]);
            Assert.Equal(4, actual[4]);
        }
    }
}
