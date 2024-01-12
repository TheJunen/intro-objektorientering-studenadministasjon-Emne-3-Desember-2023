using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Grade
    {
        public string student {  get; set; }
        public string subject { get; set; }
        public int grade { get; set; }
        public List<int> subjectgrade { get; private set; }

        public Grade(string Student, string Subject, int Grade)
        {
            student = Student;
            subject = Subject;
            grade = Grade;
            subjectgrade = new List<int>();
        }

        public void writeOutInfo()
        {
            Console.WriteLine($"student: {student}, subjectName: {subject}, grade: {grade}");
            foreach (var grade in subjectgrade)
            {
                Console.WriteLine($"The grades is set up in parallel with the subject order: {grade}");
            }
        }

        public void averageGrade()
        {

            float result = subjectgrade.Sum() / 4f;
            Console.WriteLine($"{result}");
            
        }
    }
}
