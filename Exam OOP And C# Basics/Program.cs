using Exam_OOP_C_Basics;
using System.Diagnostics;

namespace Exam_OOP_And_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 01 : Create  Final Exam 

            //Subject subject01 = new Subject(1, "C# Basics");
            //FinalExam finalExam = new FinalExam(DateTime.Now, 20, 3);

            //// Q01 : 
            //TrueOrFalseQuestion question01 = new TrueOrFalseQuestion("Q01", " 'int' this is a data type for integers ?", 1);
            //question01.RightAnswer = question01.ListOfAnswer[0];

            ////Q02 : 
            //McqQuestion question02 = new McqQuestion("Q02", "  what is a data type for integers ?", 1, 4);
            //question02.ListOfAnswer[0] = new Answer(1, "int");
            //question02.ListOfAnswer[1] = new Answer(2, "double");
            //question02.ListOfAnswer[2] = new Answer(3, "float");
            //question02.ListOfAnswer[3] = new Answer(4, "string");
            //question02.RightAnswer = question02.ListOfAnswer[0];


            ////Q03: 
            //McqQuestion question03 = new McqQuestion("Q03", "  It is a type of variable that contains texts.?", 1, 4);
            //question03.ListOfAnswer[0] = new Answer(1, "float");
            //question03.ListOfAnswer[1] = new Answer(2, "int");
            //question03.ListOfAnswer[2] = new Answer(3, "string");
            //question03.ListOfAnswer[3] = new Answer(4, "bool");
            //question03.RightAnswer = question03.ListOfAnswer[2];


            //finalExam.AddQuestion(question01);
            //finalExam.AddQuestion(question02);
            //finalExam.AddQuestion(question03);
            //subject01.CreateExam(finalExam);
            //subject01.ShowSubject();


            #endregion



            #region Example 02 : Create practical Exam 


            //Subject subject02 = new Subject(2, "C# Basics");
            //PracticalExam practicalExam = new PracticalExam(DateTime.Now, .12, 3);

            ////Q01:invalid : Because it is not possible to add an (true or false ) question in the practical exam
            //TrueOrFalseQuestion question201 = new TrueOrFalseQuestion("Q01: ", " 'int' this is a data type for integers ?", 2);
            //question201.UserAnswer = question201.ListOfAnswer[0];


            //// Q02: 
            //McqQuestion question202 = new McqQuestion("Q02", "  what is a data type for integers ?", 1, 4);
            //question202.ListOfAnswer[0] = new Answer(1, "int");
            //question202.ListOfAnswer[1] = new Answer(2, "double");
            //question202.ListOfAnswer[2] = new Answer(3, "float");
            //question202.ListOfAnswer[3] = new Answer(4, "string");
            //question202.RightAnswer = question202.ListOfAnswer[0];


            ////Q03 : 
            //McqQuestion question203 = new McqQuestion("Q03", " it is a type of variable that contains texts ?", 1, 4);
            //question203.ListOfAnswer[0] = new Answer(1, "float");
            //question203.ListOfAnswer[1] = new Answer(2, "int");
            //question203.ListOfAnswer[2] = new Answer(3, "string");
            //question203.ListOfAnswer[3] = new Answer(4, "bool");
            //question203.RightAnswer = question203.ListOfAnswer[2];

            //practicalExam.AddQuestion(question201);
            //practicalExam.AddQuestion(question202);
            //practicalExam.AddQuestion(question203);
            //subject02.CreateExam(practicalExam);
            //subject02.ShowSubject();

            #endregion







        }
    }
}
