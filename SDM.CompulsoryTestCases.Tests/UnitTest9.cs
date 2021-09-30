using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using SDM.CompulsoryTestCases.Service;

namespace SDM.CompulsoryTestCases.Tests
{
    public class UnitTest9
    {
        private ReviewService _reviewService;
        [SetUp]
        public void Setup()
        {
            _reviewService = new ReviewService();
        }
        //Test: GetTopRatedMovies Method
        [Test]
        public void TestReviewerWithIdZero()
        {
            var input = 0;
            Assert.Throws<InvalidDataException>( () => _reviewService.GetTopRatedMovies(input));
        }
        [Test]
        public void TestListNumbers()
        {
            var expectedResult = new List<int>{666666,822109,2207774,372233,814701};
            var input = 5;
            var result = _reviewService.GetTopRatedMovies(input);
            Assert.That(result,Is.EqualTo(expectedResult));
        }
    }
}