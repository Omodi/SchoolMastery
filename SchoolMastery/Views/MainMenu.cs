﻿using System;
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
    public partial class FormMainMenu : UserControl
    {
        public Profile profileCurrent;
        private BaseWindow bas;
        public FormMainMenu(Profile profile, BaseWindow baseWindow)
        {
            this.profileCurrent = profile;
            this.bas = baseWindow;
            InitializeComponent();
            nameLabel.Text = profile.getName();
            gradeLabel.Text = "Grade " + profile.getGradeLevel().ToString();
            if (this.profileCurrent.currentTest == null)
            {
                loadTestButton.Enabled = false;
            }
            else
            {
                loadTestButton.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormQuestion newForm = new FormQuestion(this.profileCurrent, this.profileCurrent.currentTest, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.profileCurrent.currentTest == null)
            {
                FormNewTest a = new FormNewTest(profileCurrent, bas);
                this.Hide();
                bas.changeUserControl(a, "SchoolMastery - Create Test");
            }
            else
            {
                var result = MessageBox.Show("Do you want to overwrite current test?", "Overwrite" ,  MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FormNewTest a = new FormNewTest(profileCurrent, bas);
                    this.Hide();
                    bas.changeUserControl(a, "SchoolMastery - Create Test");
                }
            }
            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            bas.Close();
        }

        private void loadTestButton_Click(object sender, EventArgs e)
        {

        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            FormStatistics a = new FormStatistics(this.profileCurrent, bas);
            this.Hide();
            bas.changeUserControl(a, "SchoolMastery - Score");
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectProfileButton_Click(object sender, EventArgs e)
        {
            FormSelectProfile a = new FormSelectProfile(bas);
            this.Hide();
            bas.changeUserControl(a, "SchoolMastery - Select Profile");
        }
    }
}
