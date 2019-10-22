using System;
using System.Collections.Generic;

namespace HSLesson.Models
{
    public class Subject : Entity
    {
        public string SubjectName { get; set; }
        public Mentor Mentor { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}