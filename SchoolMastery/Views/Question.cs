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

namespace SchoolMastery.Views
{
    public partial class FormQuestion : UserControl
    {
        private Question question;
        private Test test;
        private Profile profile;
        private BaseWindow bas;
        public FormQuestion(Profile profile, Test test, BaseWindow baseWindow)
        {
            this.bas = baseWindow;
            this.test = test;
            this.profile = profile;
            InitializeComponent();
            progressBar.Value = test.getProgress();
            Question question = test.getQuestions()[test.problemIndex];
            this.profile.currentTest = test;
            this.question = question;
            QuestionTextBox.Text = question.getQuestion();
            radioButton1.Text = question.getAnswers()[0];
            radioButton2.Text = question.getAnswers()[1];
            radioButton3.Text = question.getAnswers()[2];
            radioButton4.Text = question.getAnswers()[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkedButton = 0;
            if (radioButton1.Checked)
            {
                checkedButton = 1;
            }
            else if(radioButton2.Checked)
            {
                checkedButton = 2;
            }
            else if (radioButton3.Checked)
            {
                checkedButton = 3;
            }
            else if (radioButton4.Checked)
            {
                checkedButton = 4;
            }
            if (checkedButton.ToString() == this.question.getCorrectAnswer())
            {
                this.question.correct = true;
                var result = MessageBox.Show("You were correct!");
                this.question.correct = true;
                this.test.problemIndex++;
                if (this.test.problemIndex >= this.test.getQuestions().Count)
                {
                    this.test.finished = true;
                    FormTestFinished newForm = new FormTestFinished( this.profile, this.test, this.bas);
                    this.Hide();
                    bas.changeUserControl(newForm, "SchoolMastery - Results");
                }
                else
                {
                    FormQuestion newForm = new FormQuestion(this.profile, this.test, this.bas);
                    this.Hide();
                    bas.changeUserControl(newForm, "SchoolMastery - Test");
                }
            }
            else
            {
                this.question.correct = false;
                var result = MessageBox.Show("You were incorrect!\nThe correct answer was " + question.getAnswers()[Convert.ToInt32(question.getCorrectAnswer())- 1]);
                this.question.correct = false;
                this.test.problemIndex++;
                if (this.test.problemIndex >= this.test.getQuestions().Count)
                {
                    this.test.finished = true;
                    FormTestFinished newForm = new FormTestFinished(this.profile, this.test, this.bas);
                    this.Hide();
                    bas.changeUserControl(newForm, "SchoolMastery - Results");
                }
                else
                {
                    FormQuestion newForm = new FormQuestion(this.profile, this.test, this.bas);
                    this.Hide();
                    bas.changeUserControl(newForm, "SchoolMastery - Test");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMainMenu newForm = new FormMainMenu(this.profile, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormQuestionHelp newForm = new FormQuestionHelp(this.profile, this.test, this.question, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Help Question");
        }
    }
}
