using System;

namespace Mood_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyser Problem!");


            AbilityToCheckMoodHappyOrSad moodanalyser = new AbilityToCheckMoodHappyOrSad();
            string res = moodanalyser.MoodAna("happy");
            //string res1 = moodanalyser.} HandleException("I am in happy mood");
                Console.WriteLine(res);
               // Console.WriteLine(res1);
        }
        }
    }