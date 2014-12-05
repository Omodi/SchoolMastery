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
    public partial class FormTestFinished : UserControl
    {
        private Profile profile;
        private BaseWindow bas;
        public FormTestFinished(Profile profile, Test test, BaseWindow baseWindow)
        {
            this.bas = baseWindow;
            this.profile = profile;
            profile.currentTest = null;
            InitializeComponent();
            int score = test.getScore();
            if (score > 50)
            {
                congratsLabel.Text = "Congratulations!\nYou passed!\n\nScore: " + score.ToString();
            }
            else
            {
                congratsLabel.Text = "Better Luck next time!\nYou failed!\n\nScore: " + score.ToString();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormMainMenu newForm = new FormMainMenu(this.profile, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");
        }
    }
}
