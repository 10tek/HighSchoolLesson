using System.Collections.Generic;

namespace HSLesson.Models
{
    public class Mentor:Entity
    {
        public string FullName { get; set; }
        public int Stage { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
