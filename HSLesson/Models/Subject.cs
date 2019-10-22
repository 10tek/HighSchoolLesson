using System;
using System.Collections.Generic;

namespace HSLesson.Models
{
    public class Subject : Entity
    {
        public string SubjectName { get; set; }
        public virtual Mentor Mentor { get; set; }
        public virtual ICollection<SubjectsStudents> Students { get; set; } = new List<SubjectsStudents>();
    }
}