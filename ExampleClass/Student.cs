using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleClass
{
    class Student
    {
        int studentID;
        public string studentName; //incorrect way to access variables from other classes but okay in our class(Code Maine)
        double score;

        public Student()
        {
            score = 4;
        }
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            if(name.Length > 8)
            {
                score = 3.5;
            }
            else
            {
                score = 4;
            }
        }

        public int StudentID //correct way
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        /// <summary>
        /// Prints out Student ID and Name to the console
        /// </summary>
        public void Student_Info()
        {
            Console.WriteLine("Student ID: {0}", studentID);
            Console.WriteLine("Student Name: {0}", studentName);
            Console.WriteLine("Student Score: {0}", score);
        }

        public void Set_Student_Info(int id, string name)
        {
            studentID = id;
            studentName = name;
        }

        public static void Student_Handbook()
        {
            Console.WriteLine("Students will avoid being caught doing embarising crimes or their parents will have to build a new school building");
        }

    }
}
