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
        private HelpQuestion helpQuestion;
        private string question;
        private string correctAnswer;
        private List<string> answers;
        public bool correct;
        public Question() { }
        public Question(HelpQuestion help, string q, List<string> a, string correct)
        {
            this.helpQuestion = help;
            this.answers = a;
            this.question = q;
            this.correctAnswer = correct;
        }
        public HelpQuestion getHelpQuestion()
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
