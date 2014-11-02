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
        PictureBox currentPicture;
        public FormCreateProfile()
        {
            InitializeComponent();
            this.currentPicture = this.puppyPic;
        }

        private void puppyPic_Click(object sender, EventArgs e)
        {
            this.currentPicture = this.puppyPic;
            this.selectionIndicator.Location = new Point(152, 287);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //try
            //{
                Profile profile = new Profile(currentPicture, nameTextBox.Text, gradeDropDown.SelectedItem.ToString());
                FormSelectProfileNew a = new FormSelectProfileNew(profile);
                a.Show();
            //}
            //catch (NullReferenceException) { }
        }

        private void kittyPic_Click(object sender, EventArgs e)
        {
            currentPicture = kittyPic;
            this.selectionIndicator.Location = new Point(374, 287);
        }

        private void cowPic_Click(object sender, EventArgs e)
        {
            currentPicture = cowPic;
            this.selectionIndicator.Location = new Point(601, 287);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FormSelectProfile a = new FormSelectProfile();
            a.Activate();
            this.Close();
        }

    }
}
