using HSLesson.Models;
using Microsoft.EntityFrameworkCore;

namespace HSLesson.Data.Access
{
    public class HighContext : DbContext
    {
        public HighContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-305-11;Database=High;Trusted_Connection=True;");
        }


    }
}
