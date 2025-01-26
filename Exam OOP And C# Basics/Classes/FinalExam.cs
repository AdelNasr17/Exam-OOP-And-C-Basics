using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal class FinalExam : BaseExam
    {
        #region Construtors
        public FinalExam(DateTime time, double duration, int numberOfQuestion) : base(time, duration, numberOfQuestion)
        {
        }
        #endregion


        #region Methods

        // Allow Adding  MCQ And ( True OR False )  Question Type To Practical Exam
        public override bool IsQuestionType(BaseQuestion question)
        {
           
                if (question is TrueOrFalseQuestion || question is McqQuestion)
                    return true;

                else
                    return false;             
        }

        public override void ShowResults()
        {
            Console.WriteLine("\n Final Exam Results :");
            base.ShowResults();
        }

        #endregion

    }
}
