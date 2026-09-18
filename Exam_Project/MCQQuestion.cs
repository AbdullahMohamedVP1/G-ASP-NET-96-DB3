using System;
using System.Collections.Generic;
using System.Text;


namespace Exam_Project
{
    internal class MCQQuestion : Question  // هيورث كل حاجه جوا الكويسشتن
    {
        public MCQQuestion() : base()
        {
            Header = "MCQ Question";
        }

        public MCQQuestion(string body, int mark) : base("MCQ Question", body, mark)
        {
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}:  Mark {Mark}");
            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer.ToString());
            }
        }

        public override bool CheckAnswer(int answerId)
        {
            return RightAnswer != null && RightAnswer.AnswerId == answerId;
        }
    }
}
