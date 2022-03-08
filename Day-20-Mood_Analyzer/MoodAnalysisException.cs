using System;
using System.Collections.Generic;
using System.Text;

namespace Day_21_Reflection_Problem
{
    public class MoodAnalysisException :Exception
    {
        public enum ExpType
        {
            Empty_Message, Null_Message
        }
        public readonly ExpType type;

        public MoodAnalysisException(ExpType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
