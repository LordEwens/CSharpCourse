using System;
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

    public class Teacher // Part 2
    {
        string firstNameTeacher;
        string lastNameTeacher;
        DateTime dateOfBirthTeacher;
        int teacherId;
        private static int teacherIdCount = 1;

        public Teacher(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstNameTeacher = firstName;
            this.lastNameTeacher = lastName;
            this.dateOfBirthTeacher = dateOfBirth;
            this.teacherId = teacherIdCount;
            teacherIdCount++;
        }
        public override string ToString() // Return full name, DOB, Student ID in readable format
        {
            string returnString = String.Concat(this.firstNameTeacher, " ", this.lastNameTeacher, " ", this.dateOfBirthTeacher.ToShortDateString(), " ", this.teacherId);
            return returnString;
        }
        public int GetAge()
        {
            int ageInYears = 0;
            TimeSpan daysSinceBirth = DateTime.Now - this.dateOfBirthTeacher;
            ageInYears = daysSinceBirth.Days / 365;
            return ageInYears;
        }

    }

}
