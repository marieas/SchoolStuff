using System;
using System.Collections.Generic;
using System.Text;

namespace Objectorientation
{
    public class SubjectHour 
    {
        public DayOfWeek TimeAndDay { get; set; }
        public Classroom Classroom { get; set; }

        public SubjectHour(DayOfWeek time, Classroom classroom)
        {
            Classroom = classroom;
            TimeAndDay = time;
        }
    }
    public class Fag
    {
        public string Fagnavn { get; set; }
        public Lærer Faglærer { get; set; }
        public List<SubjectHour> SubjectHour { get; set; }

        public Fag(Lærer lærer, List<SubjectHour> hours, string fagnavn)
        {
            Fagnavn = fagnavn;
            Faglærer = lærer;
            SubjectHour = hours;
        }
    }
}
