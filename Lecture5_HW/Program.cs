namespace Lecture5_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create courses
            var philosophyCourse = new Course("Philosophy", "Phil Philips", 90, new List<Student>());
            var alchemyCourse = new Course("Alchemy", "Alch Alchem", 45, new List<Student>());

            //Create a student1
            var student1 = new Student();

            student1.FirstName = "John";
            student1.LastName = "Doe";
            student1.Age = 19;
            student1.City = "Beijing";
            student1.Courses.Add(philosophyCourse);

            //Create a student2
            var student2 = new Student("asdf", "qwer", 22, "city", new List<Course>() { philosophyCourse, alchemyCourse });



            //Print Course
            Console.WriteLine("Printing Course:\n");

            Console.WriteLine(philosophyCourse.Print() + "\n");


            //Add a student to a course
            philosophyCourse.Students.Add(student1);


            //Print Courses
            Console.WriteLine("Printing Course after adding student to course:\n");

            Console.WriteLine(philosophyCourse.Print() + "\n");




            //Print a student 1
            Console.WriteLine("Printing Student1:\n");
            Console.WriteLine(student1.Print() + "\n");

            //Deleting a course from student1
            student1.Courses.Remove(philosophyCourse);

            //Print a student 1
            Console.WriteLine("Printing Student1 after removing course:\n");
            Console.WriteLine(student1.Print() + "\n");



            Console.WriteLine("Printing Student2:\n");
            Console.WriteLine( student2.Print());


        }
    }
}
