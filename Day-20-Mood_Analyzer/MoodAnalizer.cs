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




        /* UC2:- Handle Exception if User Provides Invalid Mood
         */
        [TestMethod]
        public void Given_Nullmood_Expecting_Exception_Result()  //Method
        {
            try
            {
                string empty = " ";
                MoodAnalyzer mood = new MoodAnalyzer(empty);
                string expected = "invalid";

                string actual = mood.Analyzer();    //act
            }

            catch ( MoodException e )
            {
                Assert.AreEqual("invalid", e.Message);  //Assert
            }
            
        }

        /* TC 2.1:- Given Null Mood Should Return Happy.
                   - To make this Test Case pass Handle NULL Scenario using try catch and return Happy.
        */
        [TestMethod]
        public void Given_Nullmood_Expecting_happy_Result()  //Method
        {
            try
            {
                string empty = null;
                MoodAnalyzer mood = new MoodAnalyzer(empty); //Create object and arrange 
                string expected = "happy";

                string actual = mood.Analyzer();    //act
            }
            catch (MoodException e)
            {
                Assert.AreEqual("happy", e.Message);  //Assert
            }
        }

            //TC 3.1:- Given Null Mood Should throw mood analysis exception.
            [TestMethod]
            public void Given_Nullmood_Should_Throw_Exception()  //Method
            {
                try
                {
                    string empty = null;
                    MoodAnalyzer1 mood = new MoodAnalyzer1(empty); //Create object and arrange 
                    string expected = "Mood should not be null";

                    string actual = mood.Analyzer1();    //act
                }
                catch (MoodException e)
                {
                    Assert.AreEqual("Mood should not be null", e.Message);  //Assert
                }
            }
        //TC 3.2    :- Given Empty Mood Should throw mood analysis exception.
        [TestMethod]
        public void Given_Emptymood_Should_Throw_Exception()  //Method
        {
            try
            {
                string empty = " ";
                MoodAnalyzer1 mood = new MoodAnalyzer1(empty); //Create object and arrange 
                string expected = "Mood should not be empty";

                string actual = mood.Analyzer1();    //act
            }
            catch (MoodException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);  //Assert
            }
        }


    }

}
      
 
