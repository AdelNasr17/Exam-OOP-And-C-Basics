using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal class Subject 
    {

        #region 1-Properties
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }

        public BaseExam Exam { get; set; }
        #endregion


        #region 2- Constructors
        public Subject(int subject_Id, string subject_Name)
        {
            Subject_Id = subject_Id;
            Subject_Name = subject_Name;
        }
        #endregion


        #region 3- Methods
        public void CreateExam(BaseExam exam)
        {
           if (exam== null)
            {
                Console.WriteLine("Can Not Create exam");
                return;
            }
            Exam = exam;
        }

        public void ShowSubject()
        {
            Console.WriteLine($"\n Subject Id : {Subject_Id} \n Subject Name : {Subject_Name} \n Number Of Questions : {Exam.NumberOfQuestion} ");
            Console.WriteLine($" Exam time  From  [ {Exam.Time} ]  \n Exam Duration : {Exam.Duration} Minutes");
            Console.WriteLine("==================================================================");
            Exam.ShowExam();
        } 
        #endregion

    }
}
