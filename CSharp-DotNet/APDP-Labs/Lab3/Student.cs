using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Student
    {
        public static int TotalStudents { get; set; } = 0;
        int StudentId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime? DayOfBirth { get; set; }
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;

        public Student()
        {
            //constructor
            TotalStudents++;
            StudentId = 0;
            FirstName = "John";
            LastName = "Doe";
            DayOfBirth = null;
        }
        public Student(int studentId, string firstName, string lastName, DateTime? dayOfBirth)
        {
            TotalStudents++;
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            DayOfBirth = dayOfBirth;
        }
        public void DisplayStudent()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Date of Birth: {(DayOfBirth.HasValue ? DayOfBirth.Value.ToShortDateString() : "N/A")}");
            Console.WriteLine($"Enrollment Date: {EnrollmentDate.ToShortDateString()}"); // Commented out, EnrollmentDate not defined
        }
    }
}
