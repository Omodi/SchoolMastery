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
using System.IO;

namespace SchoolMastery.Views
{
    public partial class FormSelectProfile : UserControl
    {
        private Profile selectedProfile;
        private BaseWindow bas;
        public FormSelectProfile(BaseWindow baseWindow)
        {
            bas = baseWindow;
            InitializeComponent();
            PictureBox testImage = new PictureBox();
            testImage.Image = plusPic.Image;
            testImage.Size = new System.Drawing.Size(200,200);
            testImage.Location = new System.Drawing.Point(440, 201);
            selectedProfile = null;
            this.puppySelected.Hide();
            //Profile test = new Profile(testImage, "Test", "1111113");
            //test.WriteXML();
            //List<Profile> profiles = ReadXML();
            /*if (profiles.Count == 0)
            {
                PictureBox create = new PictureBox();
                create.Image = plusPic.Image;
                create.Size = new System.Drawing.Size(200,200);
                create.Location = new System.Drawing.Point(440, 201);
                createNewProfileTextBox = new System.Windows.Forms.TextBox();
                createNewProfileTextBox.Location = new System.Drawing.Point(980/2, 407);
                createNewProfileTextBox.Name = "createNewProfileTextBox";
                createNewProfileTextBox.Size = new System.Drawing.Size(100, 20);
                createNewProfileTextBox.Text = "Create New Profile";
                createNewProfileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            }
            if (profiles.Count == 1)
            {

            }
            if (profiles.Count == 2)
            {

            }
            if (profiles.Count == 3)
            {

            }
            else
            {

            }*/
        }
        public List<Profile> ReadXML()
        {
            List<Profile> profiles = new List<Profile>();
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Profile));
            foreach (string fileName in getFileNames())
            {
                System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                profiles.Add( (Profile)reader.Deserialize(file) );
            }
            return profiles;

        }
        public static List<string> getFileNames()
        {
            List<string> fileNames = new List<string>();
            string[] fileEntries = Directory.GetFiles(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName + @"\SchoolMastery\");
            foreach (string fileName in fileEntries)
            {
                fileNames.Add(fileName);
            }
            return fileNames;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            bas.Close();
        }

        private void plusPic_Click(object sender, EventArgs e)
        {
            FormCreateProfile a = new FormCreateProfile(bas);
            this.Hide();
            bas.changeUserControl(a, "SchoolMastery - Create Profile");
        }

        private void createNewProfileTextBox_TextChanged(object sender, EventArgs e)
        {
            FormCreateProfile a = new FormCreateProfile(bas);
            this.Hide();
            bas.changeUserControl(a, "SchoolMastery - Create Profile");
        }

        private void puppyPic_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectProfile));
            this.selectedProfile = new Profile(this.puppyPic, "Sam", "Grade 3");
            this.puppySelected.Show();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            FormMainMenu newForm = new FormMainMenu(this.selectedProfile, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void puppySelected_Click(object sender, EventArgs e)
        {
            FormMainMenu newForm = new FormMainMenu(this.selectedProfile, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");
        }
    }
}
