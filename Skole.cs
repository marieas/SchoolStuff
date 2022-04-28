using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objectorientation
{
    public class Skole
    {
        List<Fag> Subjects { get; set; }
        List<Lærer> Lærere { get; set; }
        List<Student> Studenter { get; set; }
        List<Kurs> TilgjengeligeKurs { get; set; }

        public Skole()
        {
            Subjects = new List<Fag>();
            Lærere = new List<Lærer>();
            Studenter = new List<Student>();
           
            var lærer = new Lærer("Marie");
            List<SubjectHour> mariesHours = new List<SubjectHour>();
            mariesHours.Add(new SubjectHour(DateTime.Now.DayOfWeek, new Classroom("Digital")));

            List<Fag> MariesFag = new List<Fag>();
            MariesFag.Add(new Fag(lærer, mariesHours, "Nøkkelkompetanse"));

            TilgjengeligeKurs = new List<Kurs>();
            TilgjengeligeKurs.Add(new Kurs("Telemarkskurset", MariesFag) );

            var telemarkskurs = GetTelemarksKurs();

            var student = new Student("Atle");

            telemarkskurs.MeldPåStudentTilKurs(student);


        }

        //public Timeplan GetStudentPlan(Student student)
        //{
        //   foreach(var kurs in student.PåmeldteKurs)
        //    {
        //        var subjects = kurs.Subjects;
        //        foreach(var subject in subjects)
        //        {
        //            subject.SubjectHour
        //        }
        //    }
        //}

        public Kurs GetTelemarksKurs()
        {
            return TilgjengeligeKurs.Where(kurs => kurs.KursNavn == "Telemarkskurset").First();
        }
    }
}
