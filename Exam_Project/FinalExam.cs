using System;
using System.Collections.Generic;
using System.Text;


namespace Exam_Project
{
    internal class FinalExam : Exam
    {
        public FinalExam() : base() { }

        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");

            int totalMark = 0;
            int fullMark = 0;

            // مسؤول عن عرض كل أسئلة الامتحان واختياراتها الفور هيمر علي كل سؤال واحد واحد
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Body}");
                Questions[i].ShowQuestion();
                fullMark += Questions[i].Mark;

                Console.WriteLine("Enter your answer ID:");
                int answerId = int.Parse(Console.ReadLine());

                if (Questions[i].CheckAnswer(answerId))
                {
                    totalMark += Questions[i].Mark;
                }
            }

            // الفاينال بيعرض الاسئلة والاجابات والدرجة في الآخر
            Console.WriteLine($"\nYour Grade: {totalMark} / {fullMark}");
        }
    }
}
