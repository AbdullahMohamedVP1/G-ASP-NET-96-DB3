using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Exam_Project
{
    internal abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam() { }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();       //يعرض الامتحان للمستخدم

        public object Clone()
        {
            Exam clone = (Exam)this.MemberwiseClone();
            if (this.Questions != null)
                clone.Questions = (Question[])this.Questions.Clone();
            return clone;
        }

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return this.Time.CompareTo(other.Time);
        }

        public override string ToString()
        {
            return $"Exam - Time: {Time} mins, Questions: {NumberOfQuestions}";
        }
    }
}

