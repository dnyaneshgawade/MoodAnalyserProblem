using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser mood = new MoodAnalyser("");
            string message = mood.AnalyseMood();
            Console.WriteLine("Mood is " + message);
        }
    }
}
