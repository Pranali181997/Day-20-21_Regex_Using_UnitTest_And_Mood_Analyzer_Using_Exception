using System;
using Mood_Analyser_Programs;
using Mood_Analyzer;
using static Mood_Analyzer.MoodAnalyzer;

namespace Mood_Analyser_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyser Problem!");


            //AbilityToCheckMoodHappyOrSad moodanalyser = new AbilityToCheckMoodHappyOrSad();
            //string res = moodanalyser.MoodAna("happy");
            //Console.WriteLine(res);

            MoodAnalyzer mood = new MoodAnalyzer("happy");
            string res1 = mood.Analyzer();
            Console.WriteLine(res1);

        }
    }
}