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
    public partial class FormNewTest : UserControl
    {
        private Profile profile;
        private BaseWindow bas;
        public FormNewTest(Profile profile, BaseWindow baseWindow)
        {
            this.bas = baseWindow;
            this.profile = profile;
            InitializeComponent();
            startbutton.Enabled = false;
            List<Test> tests = TestBuilder.createTests();
            List<string> subjects = new List<string>();
            List<string> testNames = new List<string>();
            foreach(Test test in tests){
                if(!subjects.Contains(test.subject)){
                    subjects.Add(test.subject);
                }
            }
            comboBoxTest.Enabled = false;
            comboBoxSubject.Items.AddRange(subjects.ToArray());
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTest.Items.Clear();
            foreach (Test test in TestBuilder.createTests())
            {
                if (comboBoxSubject.SelectedItem.ToString() == test.subject)
                {
                    comboBoxTest.Items.Add(test.getName());
                }
            }
            if (comboBoxTest.Items.Count > 0)
            {
                comboBoxTest.Enabled = true;
            }
            else
            {
                comboBoxTest.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FormMainMenu newForm = new FormMainMenu(this.profile, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            if (comboBoxTest.SelectedItem != null) { 
                string name = comboBoxTest.SelectedItem.ToString();
                Test selectedTest = null;
                foreach (Test test in TestBuilder.createTests())
                {
                    if(test.getName() == name)
                    {
                        selectedTest = test;
                    }
                }
                this.Hide();
                FormQuestion newForm = new FormQuestion(this.profile,selectedTest, this.bas);
                bas.changeUserControl(newForm, "SchoolMastery - Test");
            }
        }

        private void comboBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            startbutton.Enabled = true;
        }

        private void QuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
