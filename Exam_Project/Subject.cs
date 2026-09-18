using System;

namespace Exam_Project
{
    internal class Subject : ICloneable
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject() { }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public object Clone()
        {
            Subject clone = (Subject)this.MemberwiseClone();
            if (this.Exam != null)
                clone.Exam = (Exam)this.Exam.Clone();
            return clone;
        }

        public override string ToString()
        {
            return $"Subject: {SubjectName} (ID: {SubjectId})";
        }
    }
}