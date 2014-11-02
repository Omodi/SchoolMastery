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
    public partial class FormNewTest : Form
    {
        private Profile profile;
        public FormNewTest(Profile profile)
        {
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
            FormMainMenu newForm = new FormMainMenu(this.profile);
            this.Hide();
            newForm.ShowDialog();

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
                FormQuestion newForm = new FormQuestion(this.profile,selectedTest);
                newForm.ShowDialog();
            }
        }

        private void comboBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            startbutton.Enabled = true;
        }
    }
}
