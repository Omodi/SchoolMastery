using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace SchoolMastery.Model
{
    public class TestBuilder
    {
        //private static string folderName = System.Environment.CurrentDirectory + @"\SchoolMastery\Tests\";
        private static string folderName = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName + @"\SchoolMastery\Tests\";
        private static List<Test> tests = new List<Test>();
        public static List<string> getFileNames()
        {
            List<string> fileNames = new List<string>();
            if (Directory.Exists(folderName))
            {
                string[] fileEntries = Directory.GetFiles(folderName);
                foreach (string fileName in fileEntries)
                {
                    fileNames.Add(fileName);
                }
                return fileNames;
            }
            else
            {
                throw new IOException();
            }
        }
        public static Test createTest(string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string name = sr.ReadLine();
                    string subject = sr.ReadLine();
                    string gradeLevel = sr.ReadLine();
                    
                    List<Question> questions = new List<Question>();
                    while(sr.Peek() >= 0){
                        string line = sr.ReadLine();
                        if (line.StartsWith("q="))
                        {
                            string questionText = line.Substring(2);
                            List<String> answers = new List<string>();
                            for (int i = 0; i < 4; i++)
                            {
                                answers.Add(sr.ReadLine().Substring(3));
                            }
                            string correct = sr.ReadLine().Substring(2);
                            string helpQuestionText = sr.ReadLine().Substring(3);
                            List<String> helpAnswers = new List<string>();
                            for (int i = 0; i < 6; i++)
                            {
                                helpAnswers.Add(sr.ReadLine().Substring(3));
                            }
                            string helpCorrect = sr.ReadLine().Substring(2);
                            HelpQuestion help = new HelpQuestion(helpQuestionText, helpAnswers.GetRange(2, 4), helpCorrect, helpAnswers.GetRange(0, 1)[0], helpAnswers.GetRange(1, 1)[0]);
                            questions.Add(new Question(help, questionText, answers, correct));
                        }
                    }
                    Test test = new Test(name, Convert.ToInt32(gradeLevel), questions, subject);
                    return test;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file. Error = " + e.ToString());
            }
            Console.WriteLine("File read was null");
            return null;
        }
        public static List<Test> createTests()
        {
            List<string> fileNames = getFileNames();
            List<Test> tests = new List<Test>();
            foreach(string fileName in fileNames){
                tests.Add(createTest(fileName));
            }
            return tests;

        }
    }
}
