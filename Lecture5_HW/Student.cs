using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_HW
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        //I have to change it to list to make it more streamlined, as per discussion
        public List<Course> Courses { get; set; }

        public Student() : this(string.Empty)
        {
        }
        public Student(string firstName) : this(firstName, string.Empty)
        {
        }

        public Student(string firstName, string lastName) : this(firstName, lastName, 0)
        {
        }

        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, new List<Course>())
        {
        }

        public Student(string firstName, string lastName, int age, string city, List<Course> courses)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = city;
            this.Courses = courses;
        }

        public string Print()
        {

            return $"First Name: {FirstName}\nLastName: {LastName}\nAge: {Age}\nCity: {City}\nCourses: {GetCourses()}";
        }

        private string GetCourses()
        {
            var printableCourses = "";
            if (Courses.Count == 0)
            {
                printableCourses = "none";
            }
            else
            {
                foreach (var course in Courses)
                {
                    if (course != null)
                    {
                        printableCourses = printableCourses + " " + course.CourseName.ToString();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return printableCourses;
        }
    }
}
