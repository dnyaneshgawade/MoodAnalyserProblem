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
            object actual = MoodAnalyserReflector.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }
        [TestMethod]
        public void GivenImproperClassName_ShouldReturnMoodAnalysisException()
        {
            string expected = "No such class";
            try
            {
                object actual = MoodAnalyserReflector.CreateMoodAnalyse("Mood.MoodAnalyser", "MoodAnalyser");
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
                object actual = MoodAnalyserReflector.CreateMoodAnalyse("MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        [TestMethod]
        public void GivenMoodAnalyserParamrterizedConstructor_ShouldReturnObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserReflector.CreateMoodAnalyseForParametrisedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser","happy");
            expected.Equals(actual);
        }
        [TestMethod]
        public void GivenImproperClassNameParameterizedConstructor_ShouldReturnMoodAnalysisException()
        {
            string expected = "No such class";
            try
            {
                object actual = MoodAnalyserReflector.CreateMoodAnalyseForParametrisedConstructor("Mood.MoodAnalyser", "MoodAnalyser","happy");
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        [TestMethod]
        public void GivenParameterizedConstructorImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "No such Constructor";
            try
            {
                object actual = MoodAnalyserReflector.CreateMoodAnalyseForParametrisedConstructor("MoodAnalyser", "MoodAnalyser","Happy");
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        [TestMethod]
        public void InvokeMethodUsingReflection_ShouldRetunHappy()
        {
            string expected = "HAPPY";
            string actual = MoodAnalyserReflector.InvokeAnalyseMood("happy", "AnalyseMood");
            expected.Equals(actual);
        }
        [TestMethod]
        public void GivenMethodnameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "No method found";
            try
            {
                string actual = MoodAnalyserReflector.InvokeAnalyseMood("Happy", "MoodAnalyser");
                expected.Equals(actual);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
