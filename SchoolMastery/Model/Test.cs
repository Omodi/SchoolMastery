using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMastery.Model
{
    [Serializable]
    public class Test
    {
        private int score = -1;
        private string name;
        private int gradeLevel;
        private List<Question> questions;
        public bool finished;
        public Test() { }
        public Test(string n, int g, List<Question> q)
        {
            this.finished = false;
            this.gradeLevel = g;
            this.questions = q;
            this.name = n;
        }
        public int getScore()
        {
            return this.score;
        }
        public int getGradeLevel()
        {
            return this.gradeLevel;
        }
        public List<Question> getQuestions()
        {
            return this.questions;
        }
        public string getName()
        {
            return this.name;
        }
        public int getGrade()
        {
            int totalScore = 0;
            foreach (Question question in this.questions)
            {
                if (totalScore > 0) { 
                    totalScore += question.score; 
                }
                
            }
            return totalScore / questions.Count;
        }
    }

}
