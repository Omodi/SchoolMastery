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
    public partial class FormStatistics : UserControl
    {
        private Profile profile;
        private BaseWindow bas;
        public FormStatistics(Profile profile, BaseWindow baseWindow)
        {
            this.bas = baseWindow;
            this.profile = profile;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormMainMenu newForm = new FormMainMenu(profile, bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");
        }
    }
}
