using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer
{
    public class AbilityToCheckMoodHappyOrSad
    {
        //message field
        public string message;

        public string MoodAna(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }

    }

 }

    




