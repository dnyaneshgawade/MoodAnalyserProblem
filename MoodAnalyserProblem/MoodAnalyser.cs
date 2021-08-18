using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public  string message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                
                message = message.ToLower();
                if (message.Length == 0)
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "You Entered Empty Mood, Enter Valid Mood");
                
                if (message.Contains("happy"))
                    return "HAPPY";
                else
                    return "SAD";
            }
            catch (NullReferenceException)
            {
                return "You Entered Null Mood, Enter Valid Mood";
            }
        }
    }
}
