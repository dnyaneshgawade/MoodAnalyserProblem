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
            Assert.AreEqual(actual, "You Entered Null Mood, Enter Valid Mood");
        }

        [TestMethod]
        public void GivenMoodAnalyserReflection_ShouldReturnObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }
        [TestMethod]
        public void GivenImproperClassName_ShouldReturnMoodAnalysisException()
        {
            string expected = "No such class";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("Mood.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        [TestMethod]
        public void GivenConstructorNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "No such Constructor";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
