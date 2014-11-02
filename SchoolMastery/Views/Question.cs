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
        public FormQuestion(Profile profile, Test test)
        {
            InitializeComponent();
            progressBar.Value = test.getProgress();
            Question question = test.getQuestions()[test.problemIndex];
            QuestionTextBox.Text = question.getQuestion();
        }
    }
}
