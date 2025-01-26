using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_C_Basics
{
    internal abstract class BaseQuestion 
    {
        #region 1- Properties
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public Answer[] ListOfAnswer { get; set; }
        public Answer RightAnswer { get; set; }

        public Answer UserAnswer { get; set; }

        #endregion


        #region 2- Constructors
        protected BaseQuestion(string header, string body, double mark, int numberOfAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            ListOfAnswer = new Answer[numberOfAnswer];
        }
        #endregion


        #region 3- Methods


        public virtual void DisplayQuestion()
        {
            Console.WriteLine($"{Header} : \n {Body}  ");
            foreach (Answer answer in ListOfAnswer)
            {
                Console.WriteLine(answer);
            }
        }



        // Define A Method To Get The Answer From The User
        public void GetUserAnswer()
        {
            bool isValidAnswer = false;
                do
                {
                try
                {
                    Console.Write(" Enter Your Answer (Id) : ");
                    bool Flag = int.TryParse(Console.ReadLine(), out int answer);

                    //  Ensure That The User's Answer is Within List Of Answer 
                    if (Flag)
                    {
                        foreach (Answer id in ListOfAnswer)
                        {
                            if (id.Answer_Id == answer)
                            {
                                UserAnswer = id;
                                isValidAnswer = true;
                                break;
                            }
                        }
                    }
                    else
                        Console.WriteLine(" invalid answer . please try again");

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                } while (!isValidAnswer);
            
        }

        #endregion

    }
}
