using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string studentProgram { get; set; }
        public int studentID { get; set; }
        //public string[] strings { get; set; }

        public List<string> subjectlist { get; private set; }
        public List<string> subjectlist2 = new List<string>{ "science", "matte", "engelsk" };

        public Student(string has, int yalla, string tifo, int ukk)
        {
            name = has;
            age = yalla;
            studentProgram = tifo;
            studentID = ukk;
            subjectlist = new List<string>();
        }

        public void writeOutInfo()
        {
            Console.WriteLine($"Student name: {name}, age: {age}, student program: {studentProgram} and student id: {studentID}");
            foreach (var subject in subjectlist)
            {
                Console.WriteLine($"{subject}, ");

            }
        }

    }
}
