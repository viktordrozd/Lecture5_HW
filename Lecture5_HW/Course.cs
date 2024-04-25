using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_HW
{
    internal class Course
    {
        public string? CourseName { get; set; }
        public string? TeacherName { get; set; }
        public int DurationDays { get; set; }
        public int NumberOfStudents { get; set; }


        public Course() : this(string.Empty)
        {
        }

        public Course(string courseName) : this (courseName, string.Empty)
        {
        }

        public Course(string courseName, string teacherName) : this (courseName, teacherName, 0) 
        { 
        }

        public Course(string courseName, string teacherName, int durationDays) : this (courseName, teacherName, durationDays, 0)
        {
        }
        
        public Course(string courseName, string teacherName, int durationDays, int numberOfStudents)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.DurationDays = durationDays;
            this.NumberOfStudents = numberOfStudents;
        }

        public string Print()
        {
            return $"Course: {CourseName}\nTeacher: {TeacherName}\nDuration: {DurationDays}\nNumber of Students: {NumberOfStudents}";
        }
    }
}
