﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public  string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            message = message.ToLower();
            if (message.Contains("happy"))
                return "HAPPY";
            else
                return "SAD";
        }
    }
}