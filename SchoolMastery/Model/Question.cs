using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMastery.Model
{
    [Serializable]
    public class Question
    {
        private Question helpQuestion;
        private string question;
        private string correctAnswer;
        private List<string> answers;
        public int score = -1;
        public Question() { }
        public Question(Question help, string q, List<string> a, string correct)
        {
            this.helpQuestion = help;
            this.answers = a;
            this.question = q;
            this.correctAnswer = correct;
        }
        public Question getHelpQuestion()
        {
            return helpQuestion;
        }
        public List<string> getAnswers()
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
