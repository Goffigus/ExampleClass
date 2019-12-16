using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleClass
{
    class ClassRoom
    {
        List<Student> classRoster = new List<Student>();
        public string classId { get; set; }
        public int gradeLevel { get; set; }

        public void Set_Class_Info(string id, int grade)
        {
            classId = id;
            gradeLevel = grade;
        }

        public void Class_Info()
        {
            Console.WriteLine("Class {0}, {1} Year", classId, gradeLevel);
        }

        public void enroll(params Student[] students) //lets people add as many or few students as they want
        {
            for(int s = 0; s < students.Length; ++s)
            {
                classRoster.Add(students[s]);
            }
        }

        public void Roster()
        {
            for(int i = 0; i < classRoster.Count; ++i)
            {
                classRoster[i].Student_Info();
            }
        }

    }
}
