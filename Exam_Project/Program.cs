using System;

namespace Exam_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");
            int examType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
            int time = int.Parse(Console.ReadLine());
            while (time < 30 || time > 180)
            {
                Console.WriteLine("Invalid time. Please enter the time for the exam (30 to 180 minutes):");
                time = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter the number of questions:");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Exam exam = examType == 1
                ? new PracticalExam(time, numberOfQuestions)
                : new FinalExam(time, numberOfQuestions);

            Question[] questions = new Question[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"\n--- Question {i + 1} ---");

                if (examType == 1)
                {
                    // Practical Exam only accepts MCQ questions
                    questions[i] = CreateMCQQuestion();
                }
                else
                {
                    // Final Exam accepts True/False or MCQ questions
                    Console.WriteLine("Enter the type of question (1 for True/False, 2 for MCQ):");
                    int questionType = int.Parse(Console.ReadLine());

                    questions[i] = questionType == 1
                        ? CreateTrueFalseQuestion()
                        : CreateMCQQuestion();
                }
            }

            exam.Questions = questions;

            Subject subject = new Subject(1, "OOP");
            subject.CreateExam(exam);

            Console.WriteLine("\nDo You Want To Start Exam (Y | N)");
            string startAnswer = Console.ReadLine();

            if (startAnswer != null && startAnswer.Trim().ToUpper() == "Y")
            {
                subject.Exam.ShowExam();
            }

            Console.WriteLine("\nExam system finished.");
        }

        static MCQQuestion CreateMCQQuestion()
        {
            Console.WriteLine("Please enter the question body:");
            string body = Console.ReadLine();

            Console.WriteLine("Please enter the question mark:");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Choices of Question:");
            Answer[] answers = new Answer[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Please enter choice number {i + 1}:");
                string choiceText = Console.ReadLine();
                answers[i] = new Answer(i + 1, choiceText);
            }

            Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
            int correctId = int.Parse(Console.ReadLine());

            MCQQuestion question = new MCQQuestion(body, mark);
            question.Answers = answers;
            question.RightAnswer = Array.Find(answers, a => a.AnswerId == correctId);

            return question;
        }

        static TrueFalseQuestion CreateTrueFalseQuestion()
        {
            Console.WriteLine("Please enter the question body:");
            string body = Console.ReadLine();

            Console.WriteLine("Please enter the question mark:");
            int mark = int.Parse(Console.ReadLine());

            TrueFalseQuestion question = new TrueFalseQuestion(body, mark);

            Console.WriteLine("Please enter the ID of the correct answer (1 for True, 2 for False):");
            int correctId = int.Parse(Console.ReadLine());
            question.RightAnswer = Array.Find(question.Answers, a => a.AnswerId == correctId);

            return question;
        }
    }
}