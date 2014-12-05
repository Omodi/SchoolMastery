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
        private bool subFlag = false;
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
                radioButton1.Text = radioButton1.Text + " <= This was your answer";
                radioButton1.ForeColor = Color.Red;
            }
            else if(radioButton2.Checked)
            {
                checkedButton = 2;
                radioButton2.Text = radioButton2.Text + " <= This was your answer";
                radioButton2.ForeColor = Color.Red;
            }
            else if (radioButton3.Checked)
            {
                checkedButton = 3;
                radioButton3.Text = radioButton3.Text + " <= This was your answer";
                radioButton3.ForeColor = Color.Red;
            }
            else if (radioButton4.Checked)
            {
                checkedButton = 4;
                radioButton4.Text = radioButton4.Text + " <= This was your answer";
                radioButton4.ForeColor = Color.Red;
            }
            if (this.question.getCorrectAnswer() == "1")
            {
                Font newFont = new Font(radioButton1.Font, FontStyle.Bold);
                radioButton1.Font = newFont;
                radioButton1.Text = question.getAnswers()[0] + " <= This is the correct answer";
                radioButton1.ForeColor = Color.Green;
            }
            else if (this.question.getCorrectAnswer() == "2")
            {
                Font newFont = new Font(radioButton2.Font, FontStyle.Bold);
                radioButton2.Font = newFont;
                radioButton2.Text = question.getAnswers()[1] + " <= This is the correct answer";
                radioButton2.ForeColor = Color.Green;
            }
            else if (this.question.getCorrectAnswer() == "3")
            {
                Font newFont = new Font(radioButton3.Font, FontStyle.Bold);
                radioButton3.Font = newFont;
                radioButton3.Text = question.getAnswers()[2] + " <= This is the correct answer";
                radioButton3.ForeColor = Color.Green;

            }
            else if (this.question.getCorrectAnswer() == "4")
            {
                Font newFont = new Font(radioButton4.Font, FontStyle.Bold);
                radioButton4.Font = newFont;
                radioButton4.Text = question.getAnswers()[3] + " <= This is the correct answer";
                radioButton4.ForeColor = Color.Green;

            }
            if (checkedButton.ToString() == this.question.getCorrectAnswer())
            {
                this.question.correct = true;

            }
            else
            {
                this.question.correct = false;
            }
            if (this.test.problemIndex >= this.test.getQuestions().Count && subFlag)
            {
                this.test.finished = true;
                FormTestFinished newForm = new FormTestFinished(this.profile, this.test, this.bas);
                this.Hide();
                bas.changeUserControl(newForm, "SchoolMastery - Results");
            }
            else if(subFlag)
            {
                FormQuestion newForm = new FormQuestion(this.profile, this.test, this.bas);
                this.Hide();
                bas.changeUserControl(newForm, "SchoolMastery - Test");
            }
            else
            {
                this.test.problemIndex++;
                subFlag = true;
                button1.Text = "Next question";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
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
