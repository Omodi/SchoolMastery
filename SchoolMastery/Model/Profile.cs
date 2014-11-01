using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMastery.Model
{
    [Serializable]
    public class Profile
    {
        private PictureBox profilePicture;
        private String name;
        //private enum Grade {k, First, Secound, Fourth, Fith, Sixth, Seventh, Eighth, Nineth, Tenth, Eleventh, Twelfth};
        private int gradeLevel;
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
        public void changeGrade(int g)
        {
            this.gradeLevel = g;
        }
        public void WriteXML()
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Profile));
            System.IO.StreamWriter file = new System.IO.StreamWriter(
                @"C:\Users\Steven\Downloads\SchoolMastery\SchoolMastery\"+this.name + ".xml");
            writer.Serialize(file, this);
            file.Close();
        }
    }
}
