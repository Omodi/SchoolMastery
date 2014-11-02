using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolMastery.Model;

namespace WindowsFormsApplication1
{
    public partial class FormQuestion : Form
    {
        private Question question;
        private Test test;
        public FormQuestion(Profile profile, Test test)
        {
            this.test = test;
            InitializeComponent();
            progressBar.Value = test.getProgress();
            Question question = test.getQuestions()[test.problemIndex];
            this.question = question;
            QuestionTextBox.Text = question.getQuestion();
            radioButton1.Text = question.getAnswers()[0];
            radioButton2.Text = question.getAnswers()[1];
            radioButton3.Text = question.getAnswers()[2];
            radioButton4.Text = question.getAnswers()[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkedButton = "invalid";
            if (radioButton1.Checked)
            {
                checkedButton = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                checkedButton = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                checkedButton = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                checkedButton = radioButton4.Text;
            }
            if (checkedButton == this.question.getCorrectAnswer())
            {
                this.question.correct = true;
                this.test.finished = true;
                this.test.problemIndex++;
                var result = MessageBox.Show("You were correct!");
            }
        }
    }
}
