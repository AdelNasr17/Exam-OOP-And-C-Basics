using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal class Answer
    {

        #region 1- Properties
        public int Answer_Id { get; set; }
        public string Answer_Text { get; set; }

        #endregion


        #region 2- Constructors
        public Answer(int answer_Id, string answer_Text)
        {
            Answer_Id = answer_Id;
            Answer_Text = answer_Text;
        }
        #endregion


        #region 3- Methods
        public override string ToString()
        {
            return $" {Answer_Id} ) {Answer_Text}";
        } 
        #endregion


    }
}
