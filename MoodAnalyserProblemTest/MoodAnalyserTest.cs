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
            MoodAnalyser mood = new MoodAnalyser("I am in Happy Mood");
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in Sad Mood");
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, "SAD");
        }
        [TestMethod]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnException()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, "HAPPY");
        }

    }
}
