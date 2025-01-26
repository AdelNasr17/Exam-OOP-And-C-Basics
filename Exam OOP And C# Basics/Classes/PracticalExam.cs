using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal class PracticalExam : BaseExam
    {
        #region Constructors
        public PracticalExam(DateTime time, double duration, int numberOfQuestion) : base(time, duration, numberOfQuestion)
        {
        }
        #endregion


        #region Methods

        // Allow Adding only MCQ Question Type To Practical Exam
        public override bool IsQuestionType(BaseQuestion question)
        {
            if (question is McqQuestion)
                return true;

            else
                return false;
        }


        public override void ShowResults()
        {
            Console.WriteLine("\n Practical Exam Results :");
             base.ShowResults();
        }
        #endregion


    }
}
