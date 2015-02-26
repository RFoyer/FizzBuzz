using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzScorer;

namespace FizzBuzzTests
{
    [TestClass]
    public class ScorerTests
    {
        [TestMethod]
        public void Score_WhenNumberGivenIs1_Returns1()
        {
            var scorer = new Scorer();
            var numberGiven = 1;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("1", actual);
        }
        [TestMethod]
        public void Score_WhenNumberGivenIs2_Returns2()
        {
            var scorer = new Scorer();
            var numberGiven = 2;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("2", actual);
        }
        [TestMethod]
        public void Score_WhenNumberGivenIs3_ReturnsFizz()
        {
            var scorer = new Scorer();
            var numberGiven = 3;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("Fizz", actual);
        }
        [TestMethod]
        public void Score_WhenNumberGivenIs5_ReturnsBuzz()
        {
            var scorer = new Scorer();
            var numberGiven = 5;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("Buzz", actual);
        }
        [TestMethod]
        public void Score_WhenNumberGivenIs6_ReturnsFizz()
        {
            var scorer = new Scorer();
            var numberGiven = 6;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("Fizz", actual);
        }
        [TestMethod]
        public void Score_WhenNumberGivenIs15_ReturnsFizzBuzz()
        {
            var scorer = new Scorer();
            var numberGiven = 15;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("FizzBuzz", actual);
        }
        [TestMethod]
        public void Score_WhenNumberGivenIs0_ReturnsNumberMustBeGreaterThanZero()
        {
            var scorer = new Scorer();
            var numberGiven = 0;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("Number must be greater than zero!", actual);
        }
        [TestMethod]
        public void Score_WhenNumberGivenIsNegative4_ReturnsNumberMustBeGreaterThanZero()
        {
            var scorer = new Scorer();
            var numberGiven = -4;

            var actual = scorer.Score(numberGiven);

            Assert.AreEqual("Number must be greater than zero!", actual);
        }
    }
}
