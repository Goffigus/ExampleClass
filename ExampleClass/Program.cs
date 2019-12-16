using System;

namespace ExampleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student.Student_Handbook();

            Student kim = new Student(); //creating new instance of a student object
            


            kim.Student_Info();
            kim.Set_Student_Info(78, "Kim Wilson");
            kim.Student_Info();

            Student kimmy = kim;

            Console.WriteLine(kimmy == kim);
            Console.WriteLine(Student.Equals(kim, kimmy));

            Student lawrence = new Student();

            lawrence.Set_Student_Info(14, "Lawrence of Aruba");
            lawrence.Student_Info();

            Console.WriteLine(kim == lawrence);

            ClassRoom english101 = new ClassRoom();

            english101.Set_Class_Info("ENG101", 2);
            english101.enroll(kim, lawrence, kimmy);
            english101.Class_Info();
            english101.Roster();

            Console.WriteLine("*****************************"); //break to show where we change the variable in Student objects
            kim.StudentID = 79;
            Console.WriteLine(kim.StudentID);
            kim.Student_Info();
            english101.Roster();

            kim.studentName = "Kim Willy-Wilson";
            kim.Student_Info();

            english101.gradeLevel = 5;
            english101.Class_Info();

            Console.WriteLine("*****************************");// using constructors

            Student wall_e = new Student(110, "Wall-E Wh1t3");

            wall_e.Student_Info();
        }
    }
}
