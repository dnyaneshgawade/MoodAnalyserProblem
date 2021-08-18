using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserProblemTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        public string EMPTY_MOOD { get; private set; }

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
            string expected = "You Entered Empty Mood, Enter Valid Mood";
            try
            {
                MoodAnalyser mood = new MoodAnalyser("");
                string actual = mood.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void GivenEmptyMessage_WhenAnalyze_ShouldReturnException()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string actual = mood.AnalyseMood();
            //string expected = "You Enterd Empty Mood, Enter Valid Mood";
            Assert.AreEqual(actual, "You Entered Null Mood, Enter Valid Mood");
        }
    }
}
