using System;

namespace SampleProject
{
    class Program
    {
        
        public static void Main1(string[] args)
        {
            Student stu1 = new Student();

            Student.schoolAddress = "456";
            Student.schoolName = "Global school,45";

            Student stu2 = new Student();
            Student stu3 = new Student();

            stu1.studentRollNumber = 1001;
            stu1.studentName = "jack";
            stu1.studentMailId = "jack@gmail.com";
            stu1.studentAddress = "#23 egp";
            stu1.studentPercentage = 45;

            Student.printStudentDetails(stu1);

            

            stu2.studentRollNumber = 1002;
            stu2.studentName = "peter";
            stu2.studentMailId = "peter@gmail.com";
            stu2.studentAddress = "#23 VNN";
            stu2.studentPercentage = 96;

            Student.printStudentDetails(stu2);


            stu3.studentRollNumber = 1003;
            stu3.studentName = "mark";
            stu3.studentMailId = "mark@gmail.com";
            stu3.studentAddress = "#23 HTT";
            stu3.studentPercentage = 89;

            Student.printStudentDetails(stu3);


        }

    }
}
 