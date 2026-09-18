using System;

namespace Exam_Project
{
    internal class PracticalExam : Exam
    {
        public PracticalExam() : base() { }

        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");

            //يعتبر نفس كود الفاينال لكن بيعرض الاجابة الصح بعد كل سؤال

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Body}");
                Questions[i].ShowQuestion();

                Console.WriteLine("Enter your answer ID:");
                Console.ReadLine();

                Console.WriteLine($"The Right Answer is: {Questions[i].RightAnswer}");
            }
        }
    }
}