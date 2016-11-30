using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = studentInfo[0];

                List<double> studentGrades = new List<double>();

                for (int j = 1; j < studentInfo.Length; j++)
                {
                    studentGrades.Add(double.Parse(studentInfo[j]));
                }

                Student student = new Student();
                student.Name = name;
                student.Grades = studentGrades;

                students.Add(student);
            }

            foreach (Student student in students.Where(s => s.AverageGrade() >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade()))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageGrade());
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get { return Grades.Average(); }
        }
    }
}
