using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions, List<Question> questions, Subject subject, ExamMode mode) : base(time, numberOfQuestions, questions, subject, mode)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            for (int i = 0; i < Questions.Count; i++)
            {
                Questions[i].Display();
            }
        }

        public override void Start()
        {
            Console.WriteLine("Final Exam");
            base.Start();
        }
        public override void Finish()
        {
            using (var writer = new StreamWriter(ResultsFile, true))
            {
                writer.WriteLine($"Final Exam Results\n");
            }
            base.Finish();

            foreach (KeyValuePair<Question, Answer> kvp in QuestionAnswerDictionary)
            {
                Console.WriteLine(kvp.Key.ToString());
                Console.WriteLine($"Your Answer: {kvp.Value.Text}");
                Console.WriteLine("---------------------------------------------------------------\n");
            }

            
            
        }
    }
}

