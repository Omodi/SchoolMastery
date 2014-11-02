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
        public int problemIndex = 0;
        public string subject;
        public Test() { }
        public Test(string n, int g, List<Question> q, string s)
        {
            this.finished = false;
            this.gradeLevel = g;
            this.questions = q;
            this.name = n;
            this.subject = s;
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
        public int getProgress()
        {
            if (problemIndex == 0)
            {
                return 0;
            }
            else
            {
                double index = Convert.ToDouble(problemIndex);
                double count = Convert.ToDouble(questions.Count);
                return Convert.ToInt32(( index/ count) * 100);
            }
        }
    }

}
