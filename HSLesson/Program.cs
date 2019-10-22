using HSLesson.Data.Access;
using HSLesson.Models;
using System;
using System.Collections.Generic;

namespace HSLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new HighContext())
            {
                var mentor = new Mentor
                {
                    FullName = "Колтыкшашев Кайрат",
                    Stage = 13
                };

                var math = new Subject
                {
                    SubjectName = "Математика",
                    Mentor = mentor
                };

                var english = new Subject
                {
                    SubjectName = "Английский язык",
                    Mentor = mentor
                };

                var firstStudent = new Student
                {
                    FullName = "Скидан Олег Сергеевич",
                    GroupName = "SEP-182",
                    Subjects = new List<Subject>
                    {
                        math, english
                    }
                };

                var secondStudent = new Student
                {
                    FullName = "Сагадиев Ернар Габитович",
                    GroupName = "SEP-182",
                    Subjects = new List<Subject>
                    {
                        math, english
                    }
                };

                context.Add(mentor);
                context.Add(firstStudent);
                context.Add(secondStudent);

                context.SaveChanges();
            }
        }
    }
}
