using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks, AnswerList answers, Answer correctanswer)
            : base(header, body, marks, answers, correctanswer)
        {
        }

        public override bool CheckAnswer(Answer studentAnswer)
        {
            return studentAnswer.Text.ToLower().Equals(CorrectAnswer.Text.ToLower());
        }

        public override void Display()
        {
            Console.WriteLine($"Decide True or False\n{base.ToString()}");
        }
    }
}
