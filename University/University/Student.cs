using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace University
{
    class Student
    {
        public string Name { get; }
        public long Number { get; }

        private List<Course> courses = new List<Course>();

        public Student(string name, long number)
        {
            Name = name;
            if (number > 9999999999)
            {
                throw new ArgumentException("Invalid Student Number! Must not be larger than 9999999999 !");
            }
            Number = number;
        }

        public override string ToString()
        {
            return $"Student {Name} (Number: {Number})";
        }

        public void RegisterFor(Course course)
        {
            courses.Add(course);
        }
    }
}
