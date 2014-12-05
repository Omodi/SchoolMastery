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
        public FormQuestionHelp(Profile profile, Test test, Question question, BaseWindow baseWindow)
        {
            this.bas = baseWindow;
            this.test = test;
            this.profile = profile;
            this.help = question.getHelpQuestion();
            InitializeComponent();
            Tips.Text = this.help.getTip();
            Steps.Text = this.help.getStep();
            QuestionTextBox.Text = this.help.getQuestion();
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
            }
            else if (radioButton2.Checked)
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
            if (checkedButton.ToString() == this.help.getCorrectAnswer())
            {
                var result = MessageBox.Show("You were correct!");
                FormQuestion newForm = new FormQuestion(this.profile, this.test, this.bas);
                this.Hide();
                bas.changeUserControl(newForm, "SchoolMastery - Test");
            }
            else
            {
                var result = MessageBox.Show("You were incorrect!\nThe correct answer was " + help.getAnswers()[Convert.ToInt32(help.getCorrectAnswer()) - 1]);
                FormQuestion newForm = new FormQuestion(this.profile, this.test, this.bas);
                this.Hide();
                bas.changeUserControl(newForm, "SchoolMastery - Test");
            }
        }
    }
}
