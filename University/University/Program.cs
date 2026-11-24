using System.Reflection.Emit;

namespace University
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // --- 10 Studenten ---
            List<Student> students = new List<Student>
            {
                new Student("Anna Huber",       24345678),
                new Student("Lukas Gruber",     25928317),
                new Student("Sophie Wagner",    24323680),
                new Student("David Pichler",    23351181),
                new Student("Lena Steiner",     26323385),
                new Student("Felix Moser",      25354583),
                new Student("Hannah Mayer",     25345683),
                new Student("Jonas Bauer",      22313281),
                new Student("Marie Hofer",      20132782),
                new Student("Tobias Leitner",   25432289)
            };

            // --- 3 Kurse ---
            List<Course> courses = new List<Course>
            {
                new Course("Programmieren 1",
                           "Grundlagen der objektorientierten Programmierung in C#",
                           6.0f),
                new Course("Algorithmen und Datenstrukturen",
                           "Sortier- und Suchverfahren, Listen, Bäume, Graphen, Komplexität",
                           7.5f),
                new Course("Datenbanksysteme",
                           "Relationales Modell, SQL, Normalisierung, Transaktionen",
                           4.5f)
            };

            // students[0] < --> courses[0];
            courses[0].Register(students[0]);
            courses[0].Register(students[1]);
            courses[0].Register(students[2]);
            courses[1].Register(students[3]);
            courses[1].Register(students[4]);
            courses[1].Register(students[5]);
            courses[2].Register(students[6]);
            courses[2].Register(students[7]);
            courses[2].Register(students[8]);
            courses[2].Register(students[9]);


            // Kurse ausgeben
            foreach(Course course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Welcher Kurs ist wichig?");
            try
            {
                int kursNummer = int.Parse(Console.ReadLine());
                kursNummer--;
                if(kursNummer < courses.Count && kursNummer >= 0)
                {
                    Console.WriteLine(courses[kursNummer].ShowStudents());
                }
            }
            catch
            {
            }

            //Aufgabe 3
            for(int i = 0; i < courses.Count; i++)
            {
                if (courses[i].MengeStudenten(4))
                {
                    Console.WriteLine("Kurs: " + courses[i].Title);
                }
            }
        }
    }
}
