using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer;
using static Mood_Analyzer.MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class MoodAnalizer
    {
        [TestMethod]
        public void CheckForSadMood()
        {
            AbilityToCheckMoodHappyOrSad mood = new AbilityToCheckMoodHappyOrSad();
            string expected = "SAD";
            string actual = mood.MoodAna("Sad");
            Assert.AreEqual(expected, actual);
        }
        /* UC-1-1.1*/
        [TestMethod]
        public void CheckForIamInSadMood()
        {
            AbilityToCheckMoodHappyOrSad mood = new AbilityToCheckMoodHappyOrSad();
            string expected = "SAD";
            string actual = mood.MoodAna("IamInSadMood");
            Assert.AreEqual(expected, actual);
        }

        /* UC-1-1.2*/
        [TestMethod]
        public void CheckForIamInAnyMood()
        {
            AbilityToCheckMoodHappyOrSad mood = new AbilityToCheckMoodHappyOrSad();
            string expected = "HAPPY";
            string actual = mood.MoodAna("IamInAnyMood");
            Assert.AreEqual(expected, actual);
        }

    }

}
      
 
