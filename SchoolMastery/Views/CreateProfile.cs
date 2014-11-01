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
    public partial class FormCreateProfile : Form
    {
        PictureBox currentPicture = null;
        public FormCreateProfile()
        {
            InitializeComponent();
        }

        private void puppyPic_Click(object sender, EventArgs e)
        {
            currentPicture = puppyPic;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentPicture, nameTextBox.Text, gradeDropDown.SelectedItem.ToString());
        }

        private void kittyPic_Click(object sender, EventArgs e)
        {
            currentPicture = kittyPic;
        }

        private void cowPic_Click(object sender, EventArgs e)
        {
            currentPicture = cowPic;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FormSelectProfile a = new FormSelectProfile();
            a.Activate();
            this.Close();
        }

    }
}
