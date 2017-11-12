using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.CrackingTheCodingInterview;
using Xunit;

namespace HackerRank.Tests.CrackingTheCodingInterview
{
    public class MakingAnagramsTests
    {
        private readonly MakingAnagrams _sut;

        public MakingAnagramsTests()
        {
            _sut = new MakingAnagrams();
        }
        
        [Fact]
        public void Sample()
        {
            const string inputA = "cde";
            const string inputB = "abc";

            var actual = _sut.FindAnagrams(inputA, inputB);

            Assert.Equal(4, actual);
        } 
    }
}
