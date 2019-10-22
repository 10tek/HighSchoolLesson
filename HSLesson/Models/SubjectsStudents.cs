using System;
using System.Collections.Generic;
using System.Text;

namespace HSLesson.Models
{
    public class SubjectsStudents :Entity
    {
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
