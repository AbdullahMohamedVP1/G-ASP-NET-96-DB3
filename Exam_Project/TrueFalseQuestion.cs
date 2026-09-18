using System;

namespace Exam_Project
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion() : base()
        {
            Header = "True/False Question";
            Answers = new Answer[]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
        }

        public TrueFalseQuestion(string body, int mark) : base("True/False Question", body, mark)
        {
            Answers = new Answer[]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
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