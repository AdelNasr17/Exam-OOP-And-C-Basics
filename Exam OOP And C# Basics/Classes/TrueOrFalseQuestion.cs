using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal class TrueOrFalseQuestion : BaseQuestion 
    {

        #region Constructors
        public TrueOrFalseQuestion(string header, string body, double mark) : base(header, body, mark, 2)
        {
            ListOfAnswer[0] = new Answer(1, "True");
            ListOfAnswer[1] = new Answer(2, "False");
        }
        #endregion


        #region Methods
        public override void DisplayQuestion()
        {
            base.DisplayQuestion();
        } 
        #endregion
    }
}
