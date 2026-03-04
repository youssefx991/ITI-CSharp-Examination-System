using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int time, int numberOfQuestions, List<Question> questions, Subject subject, ExamMode mode) : base(time, numberOfQuestions, questions, subject, mode)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practice Exam:");
            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].Display();
            }
        }

        public override void Start()
        {
            Console.WriteLine("Practice Exam");
            base.Start();
        }
        public override void Finish()
        {
            using (var writer = new StreamWriter(ResultsFile, true))
            {
                writer.WriteLine($"Practical Exam Results\n");
            }
            base.Finish();

            int QNumber = 1;
            foreach (KeyValuePair<Question, Answer> kvp in QuestionAnswerDictionary)
            {
                Console.WriteLine($"Question: {QNumber++}\t\t Your Answer: {kvp.Value.Text}\t\tCorrect Answer: {kvp.Key.CorrectAnswer.Text} \t {kvp.Key.Marks} Marks");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

            }
            Console.WriteLine($"Your total marks: {TotalStudentMarks} / {TotalExamMarks}");
        }
    }
}
