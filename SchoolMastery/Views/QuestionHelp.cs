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
    public partial class FormQuestionHelp : UserControl
    {
        private Test test;
        private Profile profile;
        private HelpQuestion help;
        private BaseWindow bas;
        private bool subFlag = false;
        public FormQuestionHelp(Profile profile, Test test, Question question, BaseWindow baseWindow)
        {
            this.bas = baseWindow;
            this.test = test;
            this.profile = profile;
            this.help = question.getHelpQuestion();
            InitializeComponent();
            Tips.Text = "Tips: " +this.help.getTip();
            Steps.Text = "Steps: " + this.help.getStep();
            QuestionTextBox.Text = "Q: " + this.help.getQuestion();
            radioButton1.Text = this.help.getAnswers()[0];
            radioButton2.Text = this.help.getAnswers()[1];
            radioButton3.Text = this.help.getAnswers()[2];
            radioButton4.Text = this.help.getAnswers()[3];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormQuestion newForm = new FormQuestion(this.profile, this.test, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Test");
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
            else if (radioButton2.Checked)
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
            if (this.help.getCorrectAnswer() == "1")
            {
                Font newFont = new Font(radioButton1.Font, FontStyle.Bold);
                radioButton1.Font = newFont;
                radioButton1.Text = help.getAnswers()[0] + " <= This is the correct answer";
                radioButton1.ForeColor = Color.Green;
            }
            else if (this.help.getCorrectAnswer() == "2")
            {
                Font newFont = new Font(radioButton2.Font, FontStyle.Bold);
                radioButton2.Font = newFont;
                radioButton2.Text = help.getAnswers()[1] + " <= This is the correct answer";
                radioButton2.ForeColor = Color.Green;
            }
            else if (this.help.getCorrectAnswer() == "3")
            {
                Font newFont = new Font(radioButton3.Font, FontStyle.Bold);
                radioButton3.Font = newFont;
                radioButton3.Text = help.getAnswers()[2] + " <= This is the correct answer";
                radioButton3.ForeColor = Color.Green;

            }
            else if (this.help.getCorrectAnswer() == "4")
            {
                Font newFont = new Font(radioButton4.Font, FontStyle.Bold);
                radioButton4.Font = newFont;
                radioButton4.Text = help.getAnswers()[3] + " <= This is the correct answer";
                radioButton4.ForeColor = Color.Green;

            }
            if (this.test.problemIndex >= this.test.getQuestions().Count && subFlag)
            {
                this.test.finished = true;
                FormTestFinished newForm = new FormTestFinished(this.profile, this.test, this.bas);
                this.Hide();
                bas.changeUserControl(newForm, "SchoolMastery - Results");
            }
            else if (subFlag)
            {
                FormQuestion newForm = new FormQuestion(this.profile, this.test, this.bas);
                this.Hide();
                bas.changeUserControl(newForm, "SchoolMastery - Test");
            }
            else
            {
                subFlag = true;
                button1.Text = "Next question";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
        }
    }
}
