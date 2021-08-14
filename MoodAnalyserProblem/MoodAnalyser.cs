using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public static string AnalyseMood(string message)
        {
            
            if (message.Contains("Happy"))
                return "HAPPY";
            else
                return "SAD";
        }
    }
}
