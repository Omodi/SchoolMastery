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
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormMainMenu : Form
    {
        public Profile profile;
        public FormMainMenu(Profile profile)
        {
            this.profile = profile;
            InitializeComponent(profile);
            nameLabel.Text = profile.getName();
            gradeLabel.Text = "Grade " + profile.getGradeLevel().ToString();
            if (this.profile.currentTest == null)
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
            FormQuestion newForm = new FormQuestion(this.profile, this.profile.currentTest);
            this.Hide();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.profile.currentTest == null)
            {
                FormNewTest a = new FormNewTest(profile);
                this.Hide();
                a.ShowDialog();
            }
            else
            {
                var result = MessageBox.Show("Do you want to overwrite current test?", "Overwrite" ,  MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FormNewTest a = new FormNewTest(profile);
                    this.Hide();
                    a.ShowDialog();
                }
            }
            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadTestButton_Click(object sender, EventArgs e)
        {

        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            FormStatistics a = new FormStatistics(this.profile);
            this.Hide();
            a.ShowDialog();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
