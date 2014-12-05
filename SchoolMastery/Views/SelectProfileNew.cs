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
    public partial class FormSelectProfileNew : UserControl
    {
        private Profile selectedProfile;
        private Profile newProfile;
        private BaseWindow bas;
        public FormSelectProfileNew(Profile newProfile, BaseWindow baseWindow)
        {
            this.bas = baseWindow;
            this.selectedProfile = newProfile;
            this.newProfile = newProfile;
            InitializeComponent();
            PictureBox testImage = new PictureBox();
            customPicture.Image = newProfile.getPicture().Image;
            customProfileGrade.Text = "Grade " + newProfile.getGradeLevel().ToString();
            customProfileName.Text = newProfile.getName();
            testImage.Image = plusPic.Image;
            testImage.Size = new System.Drawing.Size(200,200);
            testImage.Location = new System.Drawing.Point(440, 201);
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
            this.selectionIndicator.Location = new Point(145, 191);
            FormMainMenu newForm = new FormMainMenu(this.selectedProfile, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customPicture_Click(object sender, EventArgs e)
        {
            this.selectionIndicator.Location = new System.Drawing.Point(396, 191);
            selectedProfile = newProfile;
            FormMainMenu newForm = new FormMainMenu(this.selectedProfile, this.bas);
            this.Hide();
            bas.changeUserControl(newForm, "SchoolMastery - Main Menu");
        }

        private void FormSelectProfileNew_Load(object sender, EventArgs e)
        {

        }
    }
}
