
using Day7;
using System.Globalization;

namespace REDACTED_PROJECT_NAME
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Subject subject = new Subject("Mathematics");

            Student[] students =
            {
                new Student("Ahmed", 1),
                new Student("Sara", 2),
                new Student("Ali", 3),
                new Student("Lina", 4),
                new Student("Omar", 5)
            };

            foreach (Student student in students) 
                subject.Enroll(student);

            // Q1: Arithmetic
            List<Answer> a1 = [ new Answer(1, "15"), new Answer(2, "25"), new Answer(3, "35") ];
            ChooseOneQuestion mc1 = new ChooseOneQuestion("Arithmetic", "What is 5 * 5?", 5, new AnswerList(a1), a1[1]);

            // Q2: Square Roots
            List<Answer> a2 = [ new Answer(1, "7"), new Answer(2, "8"), new Answer(3, "9") ];
            ChooseOneQuestion mc2 = new ChooseOneQuestion("Roots", "What is the square root of 64?", 10, new AnswerList(a2), a2[1]);

            // Q3: Geometry
            List<Answer> a3 = [ new Answer(1, "90"), new Answer(2, "180"), new Answer(3, "360") ];
            ChooseOneQuestion mc3 = new ChooseOneQuestion("Geometry", "Sum of angles in a triangle?", 10, new AnswerList(a3), a3[1]);

            // Q1: Prime Numbers
            List<Answer> a4 = [ new Answer(1, "2"), new Answer(2, "4"), new Answer(3, "5"), new Answer(4, "9") ];
            List<Answer> correctA4 = [ a4[0], a4[2] ]; // 2 and 5 are prime
            ChooseAllQuestion ma1 = new ChooseAllQuestion("Primes", "Select all prime numbers:", 15, new AnswerList(a4), new Answer(correctA4));

            // Q2: Factors of 10
            List<Answer> a5 = [ new Answer(1, "1"), new Answer(2, "2"), new Answer(3, "3"), new Answer(4, "5") ];
            List<Answer> correctA5 = [ a5[0], a5[1], a5[3] ]; // 1, 2, and 5
            ChooseAllQuestion ma2 = new ChooseAllQuestion("Factors", "Select factors of 10:", 10, new AnswerList(a5), new Answer(correctA5));

            // Q3: Even Numbers
            List<Answer> a6 = [ new Answer(1, "12"), new Answer(2, "17"), new Answer(3, "22"), new Answer(4, "31") ];
            List<Answer> correctA6 = [ a6[0], a6[2] ]; // 12 and 22
            ChooseAllQuestion ma3 = new ChooseAllQuestion("Parity", "Select the even numbers:", 10, new AnswerList(a6), new Answer(correctA6));

            // Q1: Division
            List<Answer> tfAnswers = [ new Answer(1, "True"), new Answer(2, "False") ];
            TrueFalseQuestion tf1 = new TrueFalseQuestion("Division", "Any number divided by 1 is itself.", 5, new AnswerList(tfAnswers), tfAnswers[0]);

            // Q2: Algebra
            TrueFalseQuestion tf2 = new TrueFalseQuestion("Algebra", "If x + 5 = 10, then x = 3.", 5, new AnswerList(tfAnswers), tfAnswers[1]);

            // Q3: Constants
            TrueFalseQuestion tf3 = new TrueFalseQuestion("Constants", "The value of Pi is exactly 3.", 5, new AnswerList(tfAnswers), tfAnswers[1]);

            QuestionList practiceList = new QuestionList("Practice_Questions.txt");
            practiceList.Add(mc1);
            practiceList.Add(ma1);
            practiceList.Add(tf1);

            QuestionList finalList = new QuestionList("Final_Questions.txt");
            finalList.Add(mc2);
            finalList.Add(mc3);
            finalList.Add(ma2);
            finalList.Add(ma3);
            finalList.Add(tf2);
            finalList.Add(tf3);


            //Question[] practiceQuestions = { mc1, ma1, tf1 };
            //Question[] finalQuestions = { mc2, mc3, ma2, ma3, tf2, tf3 };

            Repository<Exam> repository = new Repository<Exam>();
            PracticeExam practiceExam = new PracticeExam(30, 3, practiceList, subject, ExamMode.Queued);
            FinalExam finalExam = new FinalExam(60, 6, finalList, subject, ExamMode.Queued);
            repository.Add(practiceExam);
            repository.Add(finalExam);
            
            Console.WriteLine("Select Exam Type:");
            Console.WriteLine("1 - Practice");
            Console.WriteLine("2 - Final");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            while (choice != "1" && choice != "2")
            {
                Console.Write("Invalid input - please enter only 1 or 2: ");
                choice = Console.ReadLine();
            }

            Console.Clear();
            repository[int.Parse(choice)-1].Start();
            repository[int.Parse(choice)-1].Finish();
        }
    }
}