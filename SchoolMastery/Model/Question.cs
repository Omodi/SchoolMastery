using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMastery.Model
{
    class Question
    {
        private Question helpQuestion;
        private string question;
        private string correctAnswer;
        private string[] answers;
        public Question(Question help, string q, string[] a, string correct)
        {
            if( a.Length != 4){
                this.helpQuestion = help;
                this.answers = a;
                this.question = q;
                this.correctAnswer = correct;
            }
            else
            {
                //throw new IndexOutOfRangeException();
            }
        }
        public Question getHelpQuestion()
        {
            return helpQuestion;
        }
        public string[] getAnswers()
        {
            return answers;
        }
        public string getCorrectAnswer()
        {
            return correctAnswer;
        }
        public string getQuestion()
        {
            return question;
        }
    }
}
