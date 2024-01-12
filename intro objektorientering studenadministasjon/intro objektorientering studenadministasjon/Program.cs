// See https://aka.ms/new-console-template for more information
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Lars", 23, "Computer Science", 001);
            {
            student1.subjectlist.Add("Geoprahy");
            student1.subjectlist.Add("economics");
            student1.subjectlist.Add("IT");
            student1.subjectlist.Add("natural sciences");

            }
            var student2 = new Student("Jostein", 43, "Banker", 002);
            student2.subjectlist.Add("graphic design");
            student2.subjectlist.Add("literature");
            student2.subjectlist.Add("algebra");
            student2.subjectlist.Add("biology");

            var student3 = new Student("Julenissen", 99, "Thief", 003);
            student3.subjectlist.Add("drama");


            student3.subjectlist.Add("music");
            student3.subjectlist.Add("art");
            student3.subjectlist.Add("literature");

            student1.writeOutInfo();
            student2.writeOutInfo();
            student3.writeOutInfo();




            var studentsubject1 = new Subject(77, "Math", 5);
            var studentsubject2 = new Subject(124, "Norwegian", 10);
            var studentsubject3 = new Subject(552, "Drama", 10);
            studentsubject1.writeOutInfo();
            studentsubject2.writeOutInfo();
            studentsubject3.writeOutInfo();



            var student1grade = new Grade(student1.name, studentsubject2.subjectName, 5);
            var student2grade = new Grade(student2.name, studentsubject2.subjectName, 2);
            var student3grade = new Grade(student3.name, studentsubject3.subjectName, 6);

            //student 1
            student1grade.subjectgrade.Add(1);
            student1grade.subjectgrade.Add(5);
            student1grade.subjectgrade.Add(4);
            student1grade.subjectgrade.Add(3);

            student2grade.subjectgrade.Add(4);
            student2grade.subjectgrade.Add(6);
            student2grade.subjectgrade.Add(6);
            student2grade.subjectgrade.Add(5);

            student3grade.subjectgrade.Add(1);
            student3grade.subjectgrade.Add(2);
            student3grade.subjectgrade.Add(1);
            student3grade.subjectgrade.Add(1);

            student1grade.writeOutInfo();
            student2grade.writeOutInfo();
            student3grade.writeOutInfo();

            Console.WriteLine("The average grades is set up in chronological order");
            student1grade.averageGrade();
            student2grade.averageGrade();
            student3grade.averageGrade();

            studentsubject1.studypointstotal.Add(10);
            studentsubject1.studypointstotal.Add(5);
            studentsubject1.studypointstotal.Add(5);
            studentsubject1.studypointstotal.Add(10);

            studentsubject2.studypointstotal.Add(0);
            studentsubject2.studypointstotal.Add(5);
            studentsubject2.studypointstotal.Add(5);
            studentsubject2.studypointstotal.Add(5);

            studentsubject3.studypointstotal.Add(10);
            studentsubject3.studypointstotal.Add(10);
            studentsubject3.studypointstotal.Add(5);
            studentsubject3.studypointstotal.Add(10);

            Console.WriteLine($"The studypoints total sum is set in chronological order starting with Student1:");
            studentsubject1.studyPointsTotal();
            studentsubject2.studyPointsTotal();
            studentsubject3.studyPointsTotal();
        }
    }
}
