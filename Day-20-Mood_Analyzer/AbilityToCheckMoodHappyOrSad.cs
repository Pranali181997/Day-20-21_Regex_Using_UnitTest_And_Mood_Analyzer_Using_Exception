using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer
{
    public class AbilityToCheckMoodHappyOrSad
    {
        
         /* UC2:- Given Null Mood Should Return Happy To make this Test Case pass Handle.            
   */
    public class MoodAnalyzer
    {
        public string message;  //instance variable      
        public MoodAnalyzer(string message) //parameterized constructor for intilizing instance member
        {
            this.message = message;
        }
        public string Analyzer()  //Analyzer method find mood
        {
            try
            {
                if (message == null)
                {
                    throw new MoodException(MoodException.ExpType.Null_Message, "happy");
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
                throw new MoodException(MoodException.ExpType.Null_Message, "Invalid");
            }
        }

    }

 }

    




