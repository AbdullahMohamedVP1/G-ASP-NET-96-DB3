using System;
using System.Collections.Generic;
using System.Text;


namespace Exam_Project
{
    internal abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; } // علشان عرف انهي الاجابه الصح

        public Question() { }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        // كل نوع سؤال هيعرض نفسه بالطريقة الخاصة بيه (اختيارات / صح وغلط)
        public abstract void ShowQuestion();

        // كل نوع سؤال هيتحقق من الاجابة بطريقته
        public abstract bool CheckAnswer(int answerId);

        public object Clone()
        {
            Question clone = (Question)this.MemberwiseClone();
            if (this.Answers != null)
                clone.Answers = (Answer[])this.Answers.Clone();
            return clone;
        }

        public int CompareTo(Question other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"{Header}: {Body}";
        }
    }
}