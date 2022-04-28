using System;
using System.Collections.Generic;
using System.Text;

namespace Objectorientation
{
    public class Kurs
    {
        public List<Fag> Subjects { get; set; }
        public List<Lærer> KursLærere { get; set; }
        public List<Student> PåmeldteStudenter { get; private set; }
        public string KursNavn { get; set; }
        public Kurs(string kursNavn, List<Fag> fag)
        {
            PåmeldteStudenter = new List<Student>();
            KursNavn = kursNavn;
            Subjects = fag;
        }
        public void MeldPåStudentTilKurs(Student studentToEnroll)
        {
            PåmeldteStudenter.Add(studentToEnroll);
            studentToEnroll.MeldPåKurs(this);
            Console.WriteLine($"Student {studentToEnroll.Navn} er påmeldt kurs {KursNavn}");
        }
    }
}
