﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SchoolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("David", "Ewens", new DateTime(1989, 10, 29));
            Console.WriteLine("Age: {0}", studentOne.GetAge());
            Console.WriteLine("ToString: {0}", studentOne.ToString());

            Student studentTwo = new Student("Teresa", "Rilling", new DateTime(1959, 10, 14));
            Console.WriteLine("Age: {0}", studentTwo.GetAge());
            Console.WriteLine("ToString: {0}", studentTwo.ToString());

            Teacher teacherOne = new Teacher("Nalini", "LastName", new DateTime(1980, 01, 01));
            Console.WriteLine("Age: {0}", teacherOne.GetAge());
            Console.WriteLine("ToString: {0}", teacherOne.ToString());
            
            Console.ReadKey();
        }
        

    }
    /*
    public class Student // Part 1
    {
        string firstNameStudent;
        string lastNameStudent;
        DateTime dateOfBirthStudent;
        int studentId;
        private static int studentIdCount = 1;

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstNameStudent = firstName;
            this.lastNameStudent = lastName;
            this.dateOfBirthStudent = dateOfBirth;
            this.studentId = studentIdCount;
            studentIdCount++;
        }
        public override string ToString() // Return full name, DOB, Student ID in readable format
        {
            string returnString = String.Concat(this.firstNameStudent, " ", this.lastNameStudent, " ", this.dateOfBirthStudent.ToShortDateString(), " ", this.studentId);
            return returnString;
        }
        public int GetAge()
        {
            int ageInYears = 0;
            TimeSpan daysSinceBirth = DateTime.Now - this.dateOfBirthStudent;
            ageInYears = daysSinceBirth.Days / 365;
            return ageInYears;
        }

    }
    */

    public class Student : Person
    {
        int studentId;
        private static int studentIdCount = 1;

        public Student(string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth)
        {
            this.studentId = studentIdCount;
            studentIdCount++;
        }

        public override string ToString()
        {
            return String.Concat(base.ToString(), " ", studentId);
        }
    }

    public class Teacher : Person // Part 2
    {

        int teacherId;
        private static int teacherIdCount = 1;

        public Teacher(string firstName, string lastName, DateTime dateOfBirth) : base(firstName, lastName, dateOfBirth) {
            this.teacherId = teacherIdCount;
            teacherIdCount++;
        }
        
        // Return full name, DOB, ID in readable format
        public override string ToString()
        {
            //string returnString = String.Concat(firstNamePerson, " ", lastNamePerson, " ", dateOfBirthPerson.ToShortDateString(), " ", teacherId);
            return String.Concat(base.ToString(), " ", teacherId);
        }

    }

    public class Course
    {
        string courseName;
        Teacher courseTeacher;
        List<Student> studentList = new List<Student>();
        int courseId;
        private static int courseIdCount = 1;

        public Course(string cName, Teacher cTeacher, List<Student> cStudents)
        {
            this.courseName = cName;
            this.courseTeacher = cTeacher;
            this.studentList = cStudents;
            this.courseId = courseIdCount;
            courseIdCount++;
        }
        
        /*
        public string GetCourseName()
        {
            return this.courseName;
        }
        public Teacher GetTeacher()
        {
            return this.courseTeacher;
        }
        */
    }

    // Part 4
    public class Grade
    {
        Course gradeCourse;
        Student gradeStudent;
        DateTime dateAcquired;
        enum Grades { A, B, C, D, E, F };
        Grades gradeOfCourse;

        public override string ToString()
        {
            switch (gradeOfCourse)
            {
                case Grades.A:
                    return "Very Good";
                case Grades.B:
                    return "Good";
                case Grades.C:
                    return "Okay";
                case Grades.D:
                    return "Not so good.";
                case Grades.E:
                    return "Bad.";
                case Grades.F:
                    return "Very bad.";
                default:
                    return "Grade error.";
            }
            
        }

    }

    // Part 5 - Person
    public class Person
    {
        public string firstNamePerson; //{ get; set; }
        public string lastNamePerson; //{ get; set; }
        public DateTime dateOfBirthPerson; //{ get; set; }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            firstNamePerson = firstName;
            lastNamePerson = lastName;
            dateOfBirthPerson = dateOfBirth;
        }
        public override string ToString()
        {
            return String.Concat(firstNamePerson, " ", lastNamePerson, " ", dateOfBirthPerson);
        }
        public int GetAge()
        {
            TimeSpan daysSinceBirth = DateTime.Now - this.dateOfBirthPerson;
            int ageInYears = daysSinceBirth.Days / 365;
            return ageInYears;
        }
    }

}
