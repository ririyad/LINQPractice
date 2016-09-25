using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLINQ
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray =
            {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },                
            };

            // using lambda expression
            Student[] teenAgeStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            // using query expression
           var teenStudents2 = from teenage in studentArray
                where teenage.Age > 12 && teenage.Age < 20
                select teenage;

           foreach (var std in teenStudents2)
                Console.WriteLine(std.StudentName);
        }
    }
}
