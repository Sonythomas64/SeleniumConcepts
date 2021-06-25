using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject
{
    class Student
    {
        public int studentRollNumber;
        public string studentName;
        public string studentMailId;

        public string studentAddress;
        public double studentPercentage;

        public static string schoolAddress;
        public static string schoolName;

        public static void printStudentDetails(Student stu) {

            

            Console.WriteLine(stu.studentRollNumber);

            Console.WriteLine(stu.studentName);
            Console.WriteLine(stu.studentMailId);

            Console.WriteLine(stu.studentAddress);
            Console.WriteLine(stu.studentPercentage);

            Console.WriteLine(Student.schoolName);
            Console.WriteLine(Student.schoolAddress);


            Console.WriteLine("---------------------------------------");

        }


    }


}
