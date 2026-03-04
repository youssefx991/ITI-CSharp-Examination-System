using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string header, string body, int marks, AnswerList answers, Answer correctanswer)
            : base(header, body, marks, answers, correctanswer)
        {
        }

        public override bool CheckAnswer(Answer studentAnswer)
        {
            return studentAnswer.Text.ToLower().Equals(CorrectAnswer.Text.ToLower());
        }

        public override void Display()
        {
            Console.WriteLine($"Choose only one answer\n{base.ToString()}");
        }
    }
}
