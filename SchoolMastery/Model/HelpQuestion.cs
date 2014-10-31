using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMastery.Model
{
    class HelpQuestion : Question
    {
        private string tip;
        private string step;
        public HelpQuestion(string q, List<string> a, string correct, string t, string s) : base(null, q, a, correct)
        {
            this.tip = t;
            this.step = s;
        }
        public string getStep()
        {
            return step;
        }
        public string getTip()
        {
            return tip;
        }
    }
}
