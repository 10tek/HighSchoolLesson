using System;
using System.Collections.Generic;
using System.Text;

namespace HSLesson.Models
{
    public class Student : Entity
    {
        public string FullName { get; set; }
        public string GroupName { get; set; }
        public virtual ICollection<SubjectsStudents> Subjects { get; set; } = new List<SubjectsStudents>();
    }
}
