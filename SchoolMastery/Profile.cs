using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMastery
{
    class Profile
    {
        private Uri profilePicture;
        private String name;
        //private enum Grade {k, First, Secound, Fourth, Fith, Sixth, Seventh, Eighth, Nineth, Tenth, Eleventh, Twelfth};
        private int grade;
        public Profile(Uri pic, String n, int g){
            this.profilePicture = pic;
            this.name = n;
            this.grade = g;
        }
        public void changeGrade(int g)
        {
            this.grade = g;
        }

    }
}
