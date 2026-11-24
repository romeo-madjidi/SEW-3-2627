namespace University
{
    class Course
    {
        public string Title { get; }

        public string Description { get; }

        public float Credits { get; }

        private List<Student> students = new List<Student>();

        public void Register(Student student)
        {
            students.Add(student);
            student.RegisterFor(this);
        }

        public Course(string title, string description, float credits)
        {
            Title = title;
            Description = description;
            Credits = credits;
        }

        public override string ToString()
        {
            string text = $"Course {Title} - {Credits} Credits, Number of registered students: {students.Count}";
            return text;
        }

        public string ShowStudents()
        {
            string text = $"Anzahl der Studenten bei {Title}: ";
            for(int i = 0; i < students.Count; i++)
            {
                text += students[i].Name;
                if(i != (students.Count - 1))
                {
                    text += ", ";
                }
            }

            return text;
        }

        public bool MengeStudenten(int anzahl)
        {
            if(students.Count >= anzahl)
            {
                return true;
            }
            return false;
        }
    }
}
