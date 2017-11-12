using HackerRank.CrackingTheCodingInterview;
using Xunit;

namespace HackerRank.Tests.CrackingTheCodingInterview
{
    public class RansomNoteTest
    {
        private readonly RansomNote _sut;

        public RansomNoteTest()
        {
            _sut = new RansomNote();
        }

        [Fact]
        public void SampleInput1()
        {
            var magazineWords = "give me one grand today night".Split(' ');
            var ransomWords = "give one grand today".Split(' ');

            var actual = _sut.CanRansomBeMadeFromMagazine(magazineWords, ransomWords);

            Assert.True(actual);
        }

        [Fact]
        public void SampleInput2()
        {
            var magazineWords = "two times three is not four".Split(' ');
            var ransomWords = "two times two is four".Split(' ');

            var actual = _sut.CanRansomBeMadeFromMagazine(magazineWords, ransomWords);

            Assert.False(actual);
        }
    }
}
