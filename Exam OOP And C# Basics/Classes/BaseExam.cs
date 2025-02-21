using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal abstract class BaseExam
    {

        #region 1- Property
        public DateTime Time { get; set; }
        public double Duration { get; set; } // Exam Duration Per Minutes
        public int NumberOfQuestion { get; set; }
        public BaseQuestion[] ListOfQuestion { get; set; }

        private int TrackAddIndex = 0; // Track The Number Of Questions Added 

        public double FinalGrade {  get; set; }

        #endregion


        #region 2- Constructors
        protected BaseExam(DateTime time, double duration, int numberOfQuestion)
        {
            Time = time;
            Duration = duration;
            NumberOfQuestion = numberOfQuestion;
            ListOfQuestion = new BaseQuestion[numberOfQuestion];
        }
        #endregion


        #region 3- Methods

        // Define A Method To Check The Type Of Question Allowed In The Exam
        public abstract bool IsQuestionType(BaseQuestion question);

        // Definition Of A Method To Add A Question To The Exam If Is Allowed And There Is Space For It In The List Of Question Array .
        public void AddQuestion(BaseQuestion question)
        {
            if(question != null)
            {             
                if (IsQuestionType(question) == true && TrackAddIndex < NumberOfQuestion)
                {
                    ListOfQuestion[TrackAddIndex] = question;
                    TrackAddIndex++;
                }
                else
                    Console.WriteLine("This Question Type Is Not Allowed For This Exam Or Cannot Add Question ");
            }
            else
            Console.WriteLine("Can not  add a  question");

        }

        // Definition Of A Method  To Display The Exam Result After Completion
        public virtual void ShowResults()
        {
            double totalMark = 0;        
            foreach (BaseQuestion question in ListOfQuestion)
            {
                if (question == null)
                {
                    continue;
                }
                    
                totalMark += question.Mark;
                Console.WriteLine($"{question.Header} : \n {question.Body}");
                Console.WriteLine($"Your Answer : {question.UserAnswer?.Answer_Text?? "No Answer"}");
                Console.WriteLine($"Right Answer : {question.RightAnswer?.Answer_Text?? " No Right Answer "}");              
                if (question.UserAnswer != null && question.RightAnswer != null && question.UserAnswer == question.RightAnswer)
                {
                    FinalGrade += question.Mark;
                }
                else
                    question.Mark = 0;

                Console.WriteLine($" Mark : {question.Mark}");              
                Console.WriteLine("__________________________________________________");   
            }
            Console.WriteLine($"\n\n Final Exam Score : {FinalGrade} Of {totalMark}\n\n");

        }


        // Define A Method To Display Exam Questions Within The Allowed Time 
        public void ShowExam()
        {
            try
            {
                DateTime endExam = Time.AddMinutes(Duration);

                foreach (BaseQuestion question in ListOfQuestion)
                {
                    if (question == null)
                    { 
                        continue; 
                    }
                    if (DateTime.Now >= endExam)
                    {
                        Console.WriteLine(" End Exam");
                        break;
                    }
                    Console.WriteLine("\n___________________________________________________\n");
                    question.DisplayQuestion();
                    question.GetUserAnswer();
                }
                Console.Clear();
                ShowResults();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
        #endregion


    }
}
