﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolMastery.Model
{
    [Serializable]
    public class Profile
    {
        private PictureBox profilePicture;
        private String name;
        //private enum Grade {k, First, Secound, Fourth, Fith, Sixth, Seventh, Eighth, Nineth, Tenth, Eleventh, Twelfth};
        private int gradeLevel;
        public Test currentTest = null;
        //public List<Test> tests = new List<Test>();
        public Profile(){}
        public Profile(PictureBox pic, String n, String g){
            this.profilePicture = pic;
            this.name = n;
            if ("Kindergarten".Equals(g))
            {
                this.gradeLevel = 0;
            }
            else
            {
                this.gradeLevel = Convert.ToInt32(g.Substring(6));
            }
        }
        public void changeGradeLevel(int g)
        {
            this.gradeLevel = g;
        }
        public string getName()
        {
            return this.name;
        }
        public int getGradeLevel()
        {
            return this.gradeLevel;
        }
        public PictureBox getPicture()
        {
            return profilePicture;
        }
        public void WriteXML()
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Profile));
            System.IO.StreamWriter file = new System.IO.StreamWriter(
                Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName + @"\SchoolMastery\"+this.name + ".xml");
            writer.Serialize(file, this);
            file.Close();
        }
    }
}
