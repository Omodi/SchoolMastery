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
    public partial class FormMainMenu : Form
    {
        public Profile profile;
        public FormMainMenu(Profile profile)
        {
            this.profile = profile;
            InitializeComponent();
            nameLabel.Text = profile.getName();
            gradeLabel.Text = "Grade " + profile.getGradeLevel().ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNewTest a = new FormNewTest(profile);
            a.Activate();
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            FormStatistics a = new FormStatistics();
            a.Activate();
            this.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
