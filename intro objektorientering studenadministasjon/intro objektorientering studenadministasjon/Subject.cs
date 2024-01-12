using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Subject
    {
        public int subjectCode {  get; set; }
        public string subjectName { get; set; }
        public int numberOfStudyPoints { get; set; }

        public List<int> studypointstotal {  get; set; }

        public Subject(int SubjectCode, string SubjectName,int NumberOfStudyPoints)
        {
            subjectCode = SubjectCode;
            subjectName = SubjectName;
            numberOfStudyPoints = NumberOfStudyPoints;

            studypointstotal = new List<int>();
        }

        public void writeOutInfo()
        {
            Console.WriteLine($"subjectCode: {subjectCode}, subjectName: {subjectName}, numberOfStudyPoints: {numberOfStudyPoints}");
        }

        public void studyPointsTotal()
        {
            float sum = studypointstotal.Sum();
            Console.WriteLine(sum);
        }
    }

}
