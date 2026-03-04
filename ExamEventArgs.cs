using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    public delegate void ExamStartedHandler(object sender, ExamEventArgs e);
    public class ExamEventArgs : EventArgs
    {
        public Subject Subject { get; set; }
        public Exam Exam { get; set; }
    }
}
