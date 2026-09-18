using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Project
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer() { }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString()
        {
            return $"{AnswerId}- {AnswerText}";
        }
    }
}
