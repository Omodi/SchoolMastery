using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolMastery.Model;

namespace SchoolMastery
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ProfilePage());
            /*List<Test> tests = TestBuilder.createTests();
            foreach (Test test in tests)
            {
                foreach(Question question in test.getQuestions()){
                    Console.WriteLine(question.getQuestion());
                    foreach(string answer in question.getAnswers()){
                        Console.WriteLine(answer);
                    }
                }
            }*/
        }
    }
}
