using Exam_OOP_C_Basics;
using System.Diagnostics;

namespace Exam_OOP_And_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Subject subject = new Subject(10, "C#");
            subject.CreateExam();
            Console.Clear();

            int Show;
            bool FlagShow;
            do
            {
                Console.Write("Do You Want To Start The Exam (1 for Yes And 2 For NO  : ");
                FlagShow = int.TryParse(Console.ReadLine(), out Show) && (Show > 0 && Show <= 2);

            } while (!FlagShow);

            if (Show == 1)
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                subject.ShowSubject();
                Console.WriteLine($"The Elapsed Time {SW.Elapsed}");
            }

        }
    }
}
