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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FormSelectProfile : Form
    {
        public FormSelectProfile()
        {
            InitializeComponent();
            PictureBox testImage = new PictureBox();
            testImage.Image = plusPic.Image;
            testImage.Size = new System.Drawing.Size(200,200);
            testImage.Location = new System.Drawing.Point(440, 201);
            Profile test = new Profile(testImage, "Test", "1111113");
            test.WriteXML();
            List<Profile> profiles = ReadXML();
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
                profiles.Add( (Profile)reader.Deserialize(file));
            }
            return profiles;

        }
        public static List<string> getFileNames()
        {
            List<string> fileNames = new List<string>();
            string[] fileEntries = Directory.GetFiles(@"C:\Users\Steven\Downloads\SchoolMastery\SchoolMastery\");
            foreach (string fileName in fileEntries)
            {
                fileNames.Add(fileName);
            }
            return fileNames;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plusPic_Click(object sender, EventArgs e)
        {
            FormCreateProfile a = new FormCreateProfile();
            a.Activate();
            this.Close();
        }

        private void createNewProfileTextBox_TextChanged(object sender, EventArgs e)
        {
            FormCreateProfile a = new FormCreateProfile();
            a.Activate();
            this.Close();
        }
    }
}