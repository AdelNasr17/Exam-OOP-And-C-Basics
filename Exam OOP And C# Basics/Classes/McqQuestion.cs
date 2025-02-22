using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal class McqQuestion : BaseQuestion
    {
        #region Constructor
        public McqQuestion(string header, string body, double mark, int numberOfAnswer) : base(header, body, mark, numberOfAnswer)
        {
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
