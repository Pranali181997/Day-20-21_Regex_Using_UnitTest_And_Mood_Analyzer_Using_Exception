using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer
{
    public class MoodException : Exception
    {
        public enum ExpType
        {
            Empty_Message, Null_Message
        }
        public readonly ExpType type;

        public MoodException(ExpType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
