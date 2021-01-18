using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.CourseTeacher = "Seher DEMİR";
            course1.ViewScore = 1000;

            Course course2 = new Course();
            course2.CourseName = "Python";
            course2.CourseTeacher = "Nuray DEMİR";
            course2.ViewScore = 10;

            Course course3 = new Course();
            course3.CourseName = "C++";
            course3.CourseTeacher = "Recep DEMİR";
            course3.ViewScore = 100;

            // Console.WriteLine(course1.CourseName + " : " + course1.CourseTeacher);
            Course[] courses = new Course[] {course1, course2, course3};

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.CourseTeacher);
            }
        }
    }
}

class Course
{
    public string CourseName { get; set; }
    public string CourseTeacher { get; set; }
    public int ViewScore { get; set; }
}