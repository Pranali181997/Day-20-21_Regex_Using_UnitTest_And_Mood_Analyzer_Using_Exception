using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer;
using static Mood_Analyzer.MoodAnalyzer;

namespace TestProject1
{
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