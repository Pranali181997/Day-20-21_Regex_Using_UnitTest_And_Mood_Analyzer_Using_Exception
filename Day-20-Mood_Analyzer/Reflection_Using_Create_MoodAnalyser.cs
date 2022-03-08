using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_21_Reflection_Problem
{
    public class Reflection_Using_Create_MoodAnalyser
    {
        //private static string classNam;

        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly assembly= Assembly.GetExecutingAssembly();
                    Type moodAnalylserType = assembly.GetType(className);
                   var res=  Activator.CreateInstance(moodAnalylserType);
                    return res;
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExpType.Empty_Message,"Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExpType.Empty_Message , "Constructor is Not Found");
            }
        }
    }
}