using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer
{
    public class AbilityToCheckMoodHappyOrSad
    {
        
  
        /* UC3:- Inform user to invalid Mood            
       */
        public class MoodAnalyzer1
        {
            public string message;  //instance variable      
            public MoodAnalyzer1(string message) //parameterized constructor for intilizing instance member
            {
                this.message = message;
            }
            public string Analyzer1()  //Analyzer method find mood
            {
                try
                {
                    if (message == null)
                    {
                        throw new MoodException(MoodException.ExpType.Null_Message, "Mood should not be null");
                    }

                    if (message.ToLower().Contains("sad"))
                    {
                        return "sad";
                    }
                    else
                    {
                        return "happy";
                    }
                }
                catch (NullReferenceException ex)
                {
                    throw new MoodException(MoodException.ExpType.Empty_Message, "Mood should not be empty");
                }


            }

        }
    }



