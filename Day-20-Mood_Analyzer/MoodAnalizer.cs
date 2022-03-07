using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer;
using static Mood_Analyzer.MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class MoodAnalizer
    {
       
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

    }

}
      
 
