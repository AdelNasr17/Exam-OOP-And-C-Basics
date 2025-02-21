using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
    


        public void CreateExam()
        {
            int typeExam;
            bool flagTypeExam;
            do
            {
                Console.Write("Please enter the type of exam you want create (1 for practical and 2 for final) : ");
                flagTypeExam = int.TryParse(Console.ReadLine(), out typeExam) && (typeExam > 0 && typeExam <= 2);

            } while (!flagTypeExam);



            DateTime dateTime;
            bool flagDateTime;
            do
            {
                Console.Write("Please enter the  Exam time(Date and Time (dd/mm/yyyy HH:mm:ss AM or PM): ");
                flagDateTime = DateTime.TryParse(Console.ReadLine(), out dateTime);
            } while (!flagDateTime);


            int duration;
            bool flagDuration;
            do
            {
                Console.Write("Please enter the duration exam in minutes : ");
                flagDuration = int.TryParse(Console.ReadLine(), out duration);
            } while (!flagDuration);



            int NumberOfQuestions;
            bool flagNumberOfQuestions;
            do
            {
                Console.Write("Please enter the number of Questions you wanted to create : ");
                flagNumberOfQuestions = int.TryParse(Console.ReadLine(), out NumberOfQuestions);
            } while (!flagNumberOfQuestions);

            Console.Clear();









            if (typeExam == 1)
            {

                Exam = new PracticalExam(dateTime, duration, NumberOfQuestions);

                Console.WriteLine("The type of questions in the practical exam is MCQ only ");
                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    Console.WriteLine($"Please Enter Question{i + 1} :  ");
                    Console.Write(" Enter Question Body : ");
                    string? body = Console.ReadLine() ?? "-";

                    double Mark;
                    bool flagMark;
                    do
                    {
                        Console.Write(" Enter Question Mark : ");
                        flagMark = double.TryParse(Console.ReadLine(), out Mark);
                    } while (!flagMark);


                    int NumberOfAnswer;
                    bool flagNumberOfAnswer;
                    do
                    {
                        Console.Write("Enter the number of answer :");
                        flagNumberOfAnswer = int.TryParse(Console.ReadLine(), out NumberOfAnswer);
                    } while (!flagNumberOfAnswer);

                    McqQuestion mcqQuestion01 = new McqQuestion($"Question {i + 1}", body, Mark, NumberOfAnswer);

                    Console.WriteLine("Enter Answers : ");
                    for (int j = 1; j <= NumberOfAnswer; j++)
                    {
                        Console.Write($"Answer{j} : ");
                        string? answer = Console.ReadLine() ?? " - ";
                        mcqQuestion01.ListOfAnswer[j - 1] = new Answer(j, answer);

                    }
                    int correctAnswer;
                    bool flagCorrectAnswer;
                    do
                    {
                        Console.Write($"Enter correct answer id ( 1 - {NumberOfAnswer}) : ");
                        flagCorrectAnswer = int.TryParse(Console.ReadLine(), out correctAnswer) && (correctAnswer > 0 && correctAnswer <= NumberOfAnswer);

                    } while (!flagCorrectAnswer);

                    mcqQuestion01.RightAnswer = mcqQuestion01.ListOfAnswer[correctAnswer - 1];


                    Exam.AddQuestion(mcqQuestion01);


                }
            }





            else
            {
                Exam = new FinalExam(dateTime, duration, NumberOfQuestions);

                int TypeQuestion;
                bool flagTypeQuestion;

                for (int i = 0; i < NumberOfQuestions; i++)
                {


                    do
                    {
                        Console.WriteLine(" \nEnter Question Type : 1  for (trou or false) And 2 for MCQ");
                        flagTypeQuestion = int.TryParse(Console.ReadLine(), out TypeQuestion) && (TypeQuestion > 0 && TypeQuestion <= 2);
                    } while (!flagTypeQuestion);



                    Console.WriteLine($"Please Enter Question{i + 1} :  ");
                    Console.Write(" Enter Question Body : ");
                    string? body = Console.ReadLine() ?? "-";

                    double Mark;
                    bool flagMark;
                    do
                    {
                        Console.Write(" Enter Question Mark : ");
                        flagMark = double.TryParse(Console.ReadLine(), out Mark);
                    } while (!flagMark);


                    int NumberOfAnswer;
                    if (TypeQuestion == 2)
                    {

                        bool flagNumberOfAnswer;
                        do
                        {
                            Console.Write("Enter the number of answer :");
                            flagNumberOfAnswer = int.TryParse(Console.ReadLine(), out NumberOfAnswer);
                        } while (!flagNumberOfAnswer);

                        McqQuestion mcqQuestion02 = new McqQuestion($"Question {i + 1}", body, Mark, NumberOfAnswer);

                        Console.WriteLine("Enter Answers : ");
                        for (int j = 1; j <= NumberOfAnswer; j++)
                        {
                            Console.Write($"Answer{j} : ");
                            string? answer = Console.ReadLine() ?? " - ";
                            mcqQuestion02.ListOfAnswer[j - 1] = new Answer(j, answer);

                        }
                        int correctAnswer;
                        bool flagCorrectAnswer;
                        do
                        {
                            Console.Write($"Enter correct answer id ( 1 - {NumberOfAnswer}) : ");
                            flagCorrectAnswer = int.TryParse(Console.ReadLine(), out correctAnswer) && (correctAnswer > 0 && correctAnswer <= NumberOfAnswer);

                        } while (!flagCorrectAnswer);

                        mcqQuestion02.RightAnswer = mcqQuestion02.ListOfAnswer[correctAnswer - 1];


                        Exam.AddQuestion(mcqQuestion02);
                    }
                    else
                    {
                        TrueOrFalseQuestion trueOrFalseQuestion = new TrueOrFalseQuestion($"Question {i + 1}", body, Mark);
                        int correctAnswer;
                        bool flagCorrectAnswer;
                        do
                        {
                            Console.Write("Enter correct answer id ( 1 for true or 2 for false ) : ");
                            flagCorrectAnswer = int.TryParse(Console.ReadLine(), out correctAnswer) && (correctAnswer > 0 && correctAnswer <= 2);

                        } while (!flagCorrectAnswer);
                        trueOrFalseQuestion.RightAnswer = trueOrFalseQuestion.ListOfAnswer[correctAnswer - 1];
                        Exam.AddQuestion(trueOrFalseQuestion);
                    }

                }

            }

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
