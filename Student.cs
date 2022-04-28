using System;
using System.Collections.Generic;
using System.Text;

namespace Objectorientation
{
    public class Student
    {
        public string Navn { get; set; }
        public int Age { get; set; }
        public bool ErLat { get; set; }
        public List<Kurs> PåmeldteKurs { get; set; }

        public Student(string navn)
        {
            PåmeldteKurs = new List<Kurs>();
               Navn = navn;
        }

        public void MeldPåKurs(Kurs kurs)
        {
            PåmeldteKurs.Add(kurs);
        }
        public void GjøreLekser()
        {

        }
        public void Studere()
        {

        }
    }
}
