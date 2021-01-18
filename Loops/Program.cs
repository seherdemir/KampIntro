using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Yazilim Gelistirme";
            string course2 = "Programlamaya Giris";
            string course3 = "Java";

            string[] courses = new string[] { "Yazilim Gelistirme", "Programlamaya Giris", "Java", "Python"};
            
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("Sayfa Sonu -- Footer");


            foreach (string course in courses)
            {
                Console.WriteLine(course); 
            }
        }
    }
}
