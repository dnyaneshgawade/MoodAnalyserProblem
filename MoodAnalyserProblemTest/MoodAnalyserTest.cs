using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserProblemTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenHappyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string actual = MoodAnalyser.AnalyseMood("I am in Happy Mood");
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string actual = MoodAnalyser.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual(actual, "SAD");
        }
    }
}
