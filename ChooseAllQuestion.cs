using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    public class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string header, string body, int marks, AnswerList answers, Answer correctanswer)
            : base(header, body, marks, answers, correctanswer)
        {
        }

        public override bool CheckAnswer(Answer studentAnswer)
        {
            string[] studentParts = studentAnswer.Text.ToLower().Trim().Split(' ');
            string[] correctParts = CorrectAnswer.Text.ToLower().Trim().Split(' ');

            if (studentParts.Length != correctParts.Length)
                return false;

            HashSet<string> studentSet = new HashSet<string>(studentParts);
            foreach (string part in correctParts)
            {
                if (!studentSet.Contains(part))
                    return false;
            }

            return true;
        }

        public override void Display()
        {
            Console.WriteLine($"Choose all correct answers\n{base.ToString()}");
        }
    }
}
